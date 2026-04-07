using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Round_Robin_Scheduling_Algorithm
{
    // Node Class
    public class ProcessNode
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public ProcessNode Next;

        public ProcessNode(int id, int burst)
        {
            ProcessId = id;
            BurstTime = burst;
            RemainingTime = burst;
            Next = null;
        }
    }

    // Circular Linked List Class
    public class RoundRobinScheduler
    {
        private ProcessNode head;
        private ProcessNode tail;

        // Add Process at End
        public void AddProcess(int id, int burst)
        {
            ProcessNode node = new ProcessNode(id, burst);

            if (head == null)
            {
                head = tail = node;
                node.Next = head;
                return;
            }

            tail.Next = node;
            node.Next = head;
            tail = node;
        }

        // Display Processes
        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No processes available");
                return;
            }

            ProcessNode temp = head;
            do
            {
                Console.WriteLine($"PID: {temp.ProcessId}, Remaining Time: {temp.RemainingTime}");
                temp = temp.Next;
            }
            while (temp != head);
        }

        // Execute Round Robin
        public void Execute(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes to execute");
                return;
            }

            ProcessNode current = head;
            ProcessNode prev = tail;
            int time = 0;

            Console.WriteLine("\n--- Round Robin Execution ---");

            while (head != null)
            {
                if (current.RemainingTime > timeQuantum)
                {
                    current.RemainingTime -= timeQuantum;
                    time += timeQuantum;
                }
                else
                {
                    time += current.RemainingTime;
                    Console.WriteLine($"Process {current.ProcessId} completed at time {time}");

                    // Remove completed process
                    if (current == head && current == tail)
                    {
                        head = tail = null;
                        break;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == head)
                            head = current.Next;
                        if (current == tail)
                            tail = prev;
                    }
                }

                prev = current;
                current = current.Next;

                if (head != null)
                {
                    Console.WriteLine("\nProcesses after round:");
                    DisplayProcesses();
                }
            }
        }
    }

    // Main / Utility Class
    public class RoundRobinMain
    {
        public static void Main(string[] args)
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler();
            int choice;

            Console.Write("Enter Time Quantum: ");
            int tq = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("\n--- Round Robin Scheduler ---");
                Console.WriteLine("1. Add Process");
                Console.WriteLine("2. Display Processes");
                Console.WriteLine("3. Execute Scheduler");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Process ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Burst Time: ");
                        int burst = int.Parse(Console.ReadLine());
                        scheduler.AddProcess(id, burst);
                        break;

                    case 2:
                        scheduler.DisplayProcesses();
                        break;

                    case 3:
                        scheduler.Execute(tq);
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
