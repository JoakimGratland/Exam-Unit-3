using System.Text.Json;
public class Task3
{


    public static void readjson()
    {
    string json = File.ReadAllText(Text.nodesJson);
    Node mainNode = JsonSerializer.Deserialize<Node>(json);
    }

    public static int sumOfNodes(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        return node.value + sumOfNodes(node.left) + sumOfNodes(node.right);
    }

    public static int highestValueNumber(int a, int b)
    {
        return a > b ? a : b;
    }


    public static int theDeepestLevel(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        return 1 + highestValueNumber(theDeepestLevel(node.left), theDeepestLevel(node.right));
    }

    public static int countNodes(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        return 1 + countNodes(node.left) + countNodes(node.right);
    }

    public static int resultOfSumOfNodes()
    {
        string json = File.ReadAllText(Text.nodesJson);
        Node mainNode = JsonSerializer.Deserialize<Node>(json);
        int sum = sumOfNodes(mainNode);
        return sum;
    }

    public static int resultOfDeepestLevel()
    {
        string json = File.ReadAllText(Text.nodesJson);
        Node mainNode = JsonSerializer.Deserialize<Node>(json);
        int deepestLevel = theDeepestLevel(mainNode);
        return deepestLevel;
    }

    public static int resultOfCountNodes()
    {
        string json = File.ReadAllText(Text.nodesJson);
        Node mainNode = JsonSerializer.Deserialize<Node>(json);
        int count = countNodes(mainNode);
        return count;
    }
}

public class Node
{
    public int value { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }
}   