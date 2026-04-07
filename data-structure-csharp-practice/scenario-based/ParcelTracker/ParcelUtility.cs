using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker
{
    internal class ParcelUtility:IParcel
    {
        private StageNode head;
        public void CreateDefaultStage()
        {
            StageNode packed = new StageNode("Packed");
            StageNode shipped = new StageNode("Shipped");
            StageNode transit = new StageNode("Transit");
            StageNode delivered = new StageNode("Delivered");

            packed.Next = shipped;
            shipped.Next = transit;
            transit.Next = delivered;

            head = packed;

            Console.WriteLine("Default Stage SuccessFully Created");
        }
        public void TrackParcel()
        {
            if (head == null)
            {
                Console.WriteLine("No Parcel Available");
                return;

            }
            StageNode temp = head;
            Console.WriteLine("Parcel Tracking Status ");

            while (temp != null)
            {
                Console.Write($"{temp.StageName}  --->  ");
                temp = temp.Next;
            }
            Console.WriteLine("Null");


        }
        public void AddCheckPoint(string afterStage, string newStage)
        {
            if (head == null)
            {
                Console.WriteLine("Parcel chain not initialized.");
                return;
            }

            StageNode temp = head;

            while (temp != null)
            {
                if (temp.StageName.Equals(afterStage, StringComparison.OrdinalIgnoreCase))
                {
                    StageNode newNode = new StageNode(newStage);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;

                    Console.WriteLine("Checkpoint added successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Stage not found.");

        }

        public void ValidateParcel()
        {
            if (head == null)
            {
                Console.WriteLine("Parcel missing.");
                return;
            }

            StageNode temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            if (temp.StageName.Equals("Delivered", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Parcel delivered successfully.");
            }
            else
            {
                Console.WriteLine("Parcel lost or delivery incomplete.");
            }
        }

    }
}
