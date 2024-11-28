using System.Collections.Generic;

public class Graph
{
    // List of linked lists to represent the adjacency list
    private readonly List<LinkedList<Node>> adjacencyList; 

    public Graph()
    {
        // Initialize the adjacency list
        adjacencyList = new();
    }
	 
    // Add a new node to the graph
    public void AddNode(Node node) 
    {
        // Create a new linked list for the node and add it to the adjacency list
        LinkedList<Node> currentList = new();
        currentList.AddLast(node);
        adjacencyList.Add(currentList);
    }

    // Add an edge between two nodes
    public void AddEdge(int src, int dst)
    {
        // Get the source node's linked list
        LinkedList<Node> currentList = adjacencyList[src];

        // Get the destination node from the linked list
        Node dstNode = adjacencyList[dst].First.Value;
        
        // Add the destination node to the source node's list
        currentList.AddLast(dstNode);
    }

    // Check if an edge exists between two nodes
    public bool CheckEdge(int src, int dst)
    {
        // Get the source node's linked list
        LinkedList<Node> currentList = adjacencyList[src];

        // Get the destination node
        Node dstNode = adjacencyList[dst].First.Value;

        // Iterate through the source node's list to check for the destination node
        foreach (Node node in currentList)
        {
            if (node == dstNode)
                return true; // Edge exists
        }

        return false; // Edge does not exist
    }

    // Print the adjacency list of the graph
    public void Print()
    {
        string output = "";

        // Iterate through each linked list in the adjacency list
        foreach (LinkedList<Node> currentList in adjacencyList)
        {
            // Iterate through the nodes in the current linked list
            foreach (Node node in currentList)
            {
                // Append the node's data to the output string
                output += node.Data + " -> "; 
            }

            output += "\n";
        }

        // Output the entire adjacency list to Unity's console
        UnityEngine.Debug.Log(output);
    }
}
