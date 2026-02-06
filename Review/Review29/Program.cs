public class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        next = null;
    }

}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Number of Nodes ");
        int n = int.Parse(Console.ReadLine());
        Node head = new Node(-1);

        Node temp = head;
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the Node Value");
            int m = int.Parse(Console.ReadLine());
            temp.next = new Node(m);
            temp = temp.next;

        }
        head = head.next;
        Node result= MiddleElement(head);
        Console.WriteLine($"Middle Element of the Linked List is :{result.data}");
        
    }
    public static Node MiddleElement(Node head)


    {
        Node slow = head;
        Node fast = head;
        while (fast != null && fast.next!=null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;

    }

}