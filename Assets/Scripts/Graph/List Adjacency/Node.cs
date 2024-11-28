public class Node
{
    // The data (character) stored in the node
    public string Data { get; private set; } 

    public Node(string data)
    {
        // Initialize the node with the given character
        Data = data; 
    }
}