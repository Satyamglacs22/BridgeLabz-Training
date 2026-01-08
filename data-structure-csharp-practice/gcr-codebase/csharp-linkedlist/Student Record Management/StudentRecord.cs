using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Student_Record_Management
{
    // Node Class
    public class StudentNode
    {
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;
        public StudentNode Next;

        public StudentNode(int roll, string name, int age, char grade)
        {
            RollNo = roll;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }

    // Linked List Class
    public class StudentLinkedList
    {
        private StudentNode head;

        // Add at Beginning
        public void AddAtBeginning(int roll, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(roll, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        // Add at End
        public void AddAtEnd(int roll, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(roll, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        // Delete by Roll Number
        public void DeleteByRoll(int roll)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.RollNo == roll)
            {
                head = head.Next;
                Console.WriteLine("Student deleted successfully");
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null && temp.Next.RollNo != roll)
                temp = temp.Next;

            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Student deleted successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        // Search by Roll Number
        public void SearchByRoll(int roll)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNo == roll)
                {
                    Console.WriteLine($"Roll: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }

        // Update Grade
        public void UpdateGrade(int roll, char grade)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNo == roll)
                {
                    temp.Grade = grade;
                    Console.WriteLine("Grade updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }

        // Display All Records
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No student records found");
                return;
            }

            StudentNode temp = head;
            Console.WriteLine("\nRoll  Name  Age  Grade");
            while (temp != null)
            {
                Console.WriteLine($"{temp.RollNo}   {temp.Name}   {temp.Age}   {temp.Grade}");
                temp = temp.Next;
            }
        }
    }

    // Main / Utility Class
    public class StudentRecord
    {
        public static void Main(string[] args)
        {
            StudentLinkedList list = new StudentLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Record Management ---");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Delete by Roll Number");
                Console.WriteLine("4. Search by Roll Number");
                Console.WriteLine("5. Update Grade");
                Console.WriteLine("6. Display All");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Roll: ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string n1 = Console.ReadLine();
                        Console.Write("Age: ");
                        int a1 = int.Parse(Console.ReadLine());
                        Console.Write("Grade: ");
                        char g1 = char.Parse(Console.ReadLine());
                        list.AddAtBeginning(r1, n1, a1, g1);
                        break;

                    case 2:
                        Console.Write("Roll: ");
                        int r2 = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string n2 = Console.ReadLine();
                        Console.Write("Age: ");
                        int a2 = int.Parse(Console.ReadLine());
                        Console.Write("Grade: ");
                        char g2 = char.Parse(Console.ReadLine());
                        list.AddAtEnd(r2, n2, a2, g2);
                        break;

                    case 3:
                        Console.Write("Enter Roll Number: ");
                        list.DeleteByRoll(int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("Enter Roll Number: ");
                        list.SearchByRoll(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Enter Roll Number: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("New Grade: ");
                        char g = char.Parse(Console.ReadLine());
                        list.UpdateGrade(r, g);
                        break;

                    case 6:
                        list.DisplayAll();
                        break;

                    case 0:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}
