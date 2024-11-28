using UnityEngine;

public class Manager : MonoBehaviour
{
    void Start()
    {
        #region Graph List

            // Create a new graph
            Graph graph = new(); 

            // Add nodes to the graph
            graph.AddNode(new Node("A"));
            graph.AddNode(new Node("B"));
            graph.AddNode(new Node("C"));
            graph.AddNode(new Node("D"));
            graph.AddNode(new Node("E"));

            // Add edges between nodes
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(4, 0);
            graph.AddEdge(4, 2);

            // Print the adjacency list of the graph
            graph.Print();

        #endregion

        #region Graph Matrix

            GraphV2 graphV2 = new(5);

            graphV2.AddNode(new Node("A"));
            graphV2.AddNode(new Node("B"));
            graphV2.AddNode(new Node("C"));
            graphV2.AddNode(new Node("D"));
            graphV2.AddNode(new Node("E"));
            
            graphV2.AddEdge(0, 1);
            graphV2.AddEdge(1, 2);
            graphV2.AddEdge(2, 3);
            graphV2.AddEdge(2, 4);
            graphV2.AddEdge(4, 0);
            graphV2.AddEdge(4, 2);

            graphV2.Print();

            Debug.Log(graph.CheckEdge(3, 2));
        
        #endregion
    }
}
