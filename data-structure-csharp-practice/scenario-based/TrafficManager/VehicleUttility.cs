using System;
using System.Text;

namespace TrafficManager
{
    public class VehicleUtility : IVehicle
    {
       // =============== (Circular Linked List) =====
        private Vehicle head;
        private Vehicle tail;
        private int currentCount;
        private int maxCapacity;

        // ===== (Queue) =====
        private Vehicle front;
        private Vehicle rear;
        private int queueCount;
        private int maxQueueSize;

        // Constructor
        public VehicleUtility(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
            this.maxQueueSize = 5;

            head = null;
            tail = null;
            currentCount = 0;

            front = null;
            rear = null;
            queueCount = 0;
        }

        // ================= ENTER VEHICLE =================
        public void EnterVehicle(int vehicleId)
        {
            if (currentCount < maxCapacity)
            {
                AddToRoundabout(vehicleId);
            }
            else
            {
                EnqueueVehicle(vehicleId);
            }
        }

        // ================= EXIT VEHICLE =================
        public void ExitVehicle()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout is empty. No vehicle to exit.");
                return;
            }

            int exitedVehicleId = head.VehicleId;

            // Only one vehicle
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                tail.Next = head;
            }

            currentCount--;
            Console.WriteLine("Vehicle " + exitedVehicleId + " exited the roundabout.");

            // Move vehicle from queue to roundabout if available
            if (queueCount > 0)
            {
                int queuedVehicleId = DequeueVehicle();
                AddToRoundabout(queuedVehicleId);
            }
        }

        // ================= DISPLAY STATUS =================
        public void DisplayStatus()
        {
            DisplayRoundabout();
            DisplayQueue();
        }

        // ================= ROUNDABOUT METHODS =================
        private void AddToRoundabout(int vehicleId)
        {
            Vehicle newVehicle = new Vehicle(vehicleId);

            if (head == null)
            {
                head = newVehicle;
                tail = newVehicle;
                newVehicle.Next = newVehicle;
            }
            else
            {
                tail.Next = newVehicle;
                newVehicle.Next = head;
                tail = newVehicle;
            }

            currentCount++;
            Console.WriteLine("Vehicle " + vehicleId + " entered the roundabout.");
        }

        private void DisplayRoundabout()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout: Empty");
                return;
            }

            Console.Write("Roundabout: ");
            Vehicle temp = head;

            do
            {
                Console.Write(temp.VehicleId + " ");
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine();
        }

        // ================= QUEUE METHODS =================
        private void EnqueueVehicle(int vehicleId)
        {
            if (queueCount == maxQueueSize)
            {
                Console.WriteLine("Waiting queue overflow. Vehicle rejected.");
                return;
            }

            Vehicle newVehicle = new Vehicle(vehicleId);

            if (front == null)
            {
                front = newVehicle;
                rear = newVehicle;
            }
            else
            {
                rear.Next = newVehicle;
                rear = newVehicle;
            }

            queueCount++;
            Console.WriteLine("Vehicle " + vehicleId + " added to waiting queue.");
        }

        private int DequeueVehicle()
        {
            if (front == null)
            {
                Console.WriteLine("Waiting queue underflow.");
                return -1;
            }

            int vehicleId = front.VehicleId;

            if (front == rear)
            {
                front = null;
                rear = null;
            }
            else
            {
                front = front.Next;
            }

            queueCount--;
            return vehicleId;
        }

        private void DisplayQueue()
        {
            if (front == null)
            {
                Console.WriteLine("Waiting Queue: Empty");
                return;
            }

            Console.Write("Waiting Queue: ");
            Vehicle temp = front;

            while (temp != null)
            {
                Console.Write(temp.VehicleId + " ");
                temp = temp.Next;
            }

            Console.WriteLine();
        }
    }
}
