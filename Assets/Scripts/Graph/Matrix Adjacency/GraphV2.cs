using System.Collections.Generic;

public class GraphV2
{
    private readonly List<Node> nodes;
    private readonly int [,] matrix;

    public GraphV2(int size) 
    {
        nodes = new();
        matrix = new int[size, size];
    }

    public void AddNode(Node node) 
    {
        nodes.Add(node);
    }

    public void AddEdge(int src, int dst) 
    {
        // Src = row
        // Dst = column
        matrix[src, dst] = 1;
    }
    
    public bool CheckEdge(int src, int dst) 
    {
        if(matrix[src, dst] == 1) return true;
        else return false;
    }

    public void Print() 
    {
        // Create the string for the header
        string output = "  ";
        
        foreach (Node node in nodes)
        {
            output += node.Data + " ";
        }

        // Append each row of the matrix to the output string
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            output += "\n" + nodes[i].Data + " "; // Add the side label (A, B, C, etc.)
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                output += matrix[i, j] + " "; // Add matrix values (0 or 1)
            }
        }

        UnityEngine.Debug.Log(output); // Log everything as a single output
    }
}
