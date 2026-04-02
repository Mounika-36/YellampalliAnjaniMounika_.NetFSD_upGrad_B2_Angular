//using System;

//class Node
//{
//    public int Id;
//    public string Name;
//    public Node Next;

//    public Node(int id, string name)
//    {
//        Id = id;
//        Name = name;
//        Next = null;
//    }
//}

//class EmployeeLinkedList
//{
//    private Node head;

//    // Insert at Beginning
//    public void InsertAtBeginning(int id, string name)
//    {
//        Node newNode = new Node(id, name);
//        newNode.Next = head;
//        head = newNode;

//        Console.WriteLine($"Inserted at Beginning: {id} - {name}");
//    }

//    // Insert at End
//    public void InsertAtEnd(int id, string name)
//    {
//        Node newNode = new Node(id, name);

//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }

//        Node temp = head;
//        while (temp.Next != null)
//        {
//            temp = temp.Next;
//        }

//        temp.Next = newNode;

//        Console.WriteLine($"Inserted at End: {id} - {name}");
//    }

//    // Delete by Employee ID
//    public void DeleteById(int id)
//    {
//        if (head == null)
//        {
//            Console.WriteLine("List is empty. Cannot delete.");
//            return;
//        }

//        // If head node is to be deleted
//        if (head.Id == id)
//        {
//            Console.WriteLine($"Deleted: {head.Id} - {head.Name}");
//            head = head.Next;
//            return;
//        }

//        Node temp = head;
//        Node prev = null;

//        while (temp != null && temp.Id != id)
//        {
//            prev = temp;
//            temp = temp.Next;
//        }

//        if (temp == null)
//        {
//            Console.WriteLine("Employee not found.");
//            return;
//        }

//        // Unlink node
//        prev.Next = temp.Next;

//        Console.WriteLine($"Deleted: {temp.Id} - {temp.Name}");
//    }

//    // Traverse and Display
//    public void Display()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("Employee List is empty.");
//            return;
//        }

//        Console.WriteLine("Employee List:");
//        Node temp = head;

//        while (temp != null)
//        {
//            Console.WriteLine($"{temp.Id} - {temp.Name}");
//            temp = temp.Next;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        EmployeeLinkedList list = new EmployeeLinkedList();

//        // Sample Input
//        list.InsertAtEnd(101, "John");
//        list.InsertAtEnd(102, "Sara");
//        list.InsertAtEnd(103, "Mike");

//        Console.WriteLine();

//        // Delete
//        list.DeleteById(102);

//        Console.WriteLine();



//        // Display
//        list.Display();
//    }
//}


using System;
namespace DSA_Problem_2
{
    class Node
    {
        public int empId;
        public string name;
        public Node next;

        public Node(int id, string name)
        {
            this.empId = id;
            this.name = name;
            this.next = null;
        }
    }

    class LinkedList
    {
        Node head = null;
        public void InsertAtBeginning(int id, string name)
        {
            Node newNode = new Node(id, name);
            newNode.next = head;
            head = newNode;
        }
        public void InsertAtEnd(int id, string name)
        {
            Node newNode = new Node(id, name);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        public void Delete(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.empId == id)
            {
                head = head.next;
                return;
            }

            Node temp = head;
            Node prev = null;

            while (temp != null && temp.empId != id)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            prev.next = temp.next;
        }

        public void Display()
        {
            Node temp = head;

            if (temp == null)
            {
                Console.WriteLine("Employee List is Empty");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine(temp.empId + " - " + temp.name);
                temp = temp.next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EMPLOYEE LINKED LIST ===");

            LinkedList list = new LinkedList();

            list.InsertAtEnd(101, "John");
            list.InsertAtEnd(102, "Sara");
            list.InsertAtEnd(103, "Mike");

            Console.WriteLine("\nBefore Deletion:");
            list.Display();

            list.Delete(102);

            Console.WriteLine("\nAfter Deletion:");
            list.Display();
        }
    }
}