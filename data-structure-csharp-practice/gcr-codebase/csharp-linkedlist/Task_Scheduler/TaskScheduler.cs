using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Task_Scheduler
{
    // Node Class
    public class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public TaskNode Next;

        public TaskNode(int id, string name, int priority, string dueDate)
        {
            TaskId = id;
            TaskName = name;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }

    // Circular Linked List Class
    public class TaskCircularList
    {
        private TaskNode head;
        private TaskNode tail;
        private TaskNode current;

        // Add at Beginning
        public void AddAtBeginning(int id, string name, int priority, string dueDate)
        {
            TaskNode node = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = tail = current = node;
                node.Next = head;
                return;
            }

            node.Next = head;
            tail.Next = node;
            head = node;
        }

        // Add at End
        public void AddAtEnd(int id, string name, int priority, string dueDate)
        {
            TaskNode node = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = tail = current = node;
                node.Next = head;
                return;
            }

            tail.Next = node;
            node.Next = head;
            tail = node;
        }

        // Remove by Task ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            TaskNode prev = tail;

            do
            {
                if (temp.TaskId == id)
                {
                    if (temp == head)
                        head = head.Next;

                    if (temp == tail)
                        tail = prev;

                    prev.Next = temp.Next;
                    Console.WriteLine("Task removed successfully");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Task not found");
        }

        // View Current Task and Move to Next
        public void ViewNextTask()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            Console.WriteLine($"Current Task: {current.TaskName}");
            current = current.Next;
        }

        // Search by Priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            bool found = false;

            do
            {
                if (temp.Priority == priority)
                {
                    DisplayTask(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No task found with given priority");
        }

        // Display All Tasks
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks to display");
                return;
            }

            TaskNode temp = head;
            do
            {
                DisplayTask(temp);
                temp = temp.Next;
            } while (temp != head);
        }

        private void DisplayTask(TaskNode task)
        {
            Console.WriteLine($"ID: {task.TaskId}, Name: {task.TaskName}, Priority: {task.Priority}, Due: {task.DueDate}");
        }
    }

    // Main / Utility Class
    public class TaskScheduler
    {
        public static void Main(string[] args)
        {
            TaskCircularList list = new TaskCircularList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Task Scheduler ---");
                Console.WriteLine("1. Add Task at Beginning");
                Console.WriteLine("2. Add Task at End");
                Console.WriteLine("3. Remove Task by ID");
                Console.WriteLine("4. View Current & Next Task");
                Console.WriteLine("5. Search by Priority");
                Console.WriteLine("6. Display All Tasks");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                        Console.Write("Task ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Task Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Priority: ");
                        int priority = int.Parse(Console.ReadLine());
                        Console.Write("Due Date: ");
                        string date = Console.ReadLine();

                        if (choice == 1)
                            list.AddAtBeginning(id, name, priority, date);
                        else
                            list.AddAtEnd(id, name, priority, date);
                        break;

                    case 3:
                        Console.Write("Enter Task ID: ");
                        list.RemoveById(int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        list.ViewNextTask();
                        break;

                    case 5:
                        Console.Write("Enter Priority: ");
                        list.SearchByPriority(int.Parse(Console.ReadLine()));
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
            }
            while (choice != 0);
        }
    }
}
