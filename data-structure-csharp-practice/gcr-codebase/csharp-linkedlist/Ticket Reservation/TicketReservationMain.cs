using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Ticket_Reservation
{
    // Node Class
    public class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public TicketNode Next;

        public TicketNode(int id, string customer, string movie, string seat, string time)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = time;
            Next = null;
        }
    }

    // Circular Linked List Class
    public class TicketCircularList
    {
        private TicketNode head;
        private TicketNode tail;

        // Add Ticket at End
        public void BookTicket(int id, string customer, string movie, string seat, string time)
        {
            TicketNode node = new TicketNode(id, customer, movie, seat, time);

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

        // Remove Ticket by ID (✔ FIXED)
        public void CancelTicket(int id)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode temp = head;
            TicketNode prev = tail;

            do
            {
                if (temp.TicketId == id)
                {
                    // ✅ Single node case
                    if (head == tail)
                    {
                        head = tail = null;
                        Console.WriteLine("Ticket cancelled successfully");
                        return;
                    }

                    // Head deletion
                    if (temp == head)
                        head = head.Next;

                    // Tail deletion
                    if (temp == tail)
                        tail = prev;

                    prev.Next = temp.Next;
                    tail.Next = head;   // maintain circular link

                    Console.WriteLine("Ticket cancelled successfully");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Ticket not found");
        }

        // Search by Customer Name
        public void SearchByCustomer(string name)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            do
            {
                if (temp.CustomerName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No ticket found for customer");
        }

        // Search by Movie Name
        public void SearchByMovie(string movie)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            do
            {
                if (temp.MovieName.Equals(movie, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No ticket found for movie");
        }

        // Display All Tickets
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode temp = head;
            do
            {
                DisplayTicket(temp);
                temp = temp.Next;
            } while (temp != head);
        }

        // Count Tickets
        public int CountTickets()
        {
            if (head == null) return 0;

            int count = 0;
            TicketNode temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }

        private void DisplayTicket(TicketNode ticket)
        {
            Console.WriteLine(
                $"ID: {ticket.TicketId}, Customer: {ticket.CustomerName}, Movie: {ticket.MovieName}, Seat: {ticket.SeatNumber}, Time: {ticket.BookingTime}"
            );
        }
    }

    // Main / Utility Class
    public class TicketReservationMain
    {
        public static void Main(string[] args)
        {
            TicketCircularList list = new TicketCircularList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Online Ticket Reservation System ---");
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Cancel Ticket");
                Console.WriteLine("3. Search by Customer");
                Console.WriteLine("4. Search by Movie");
                Console.WriteLine("5. Display All Tickets");
                Console.WriteLine("6. Count Tickets");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Ticket ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Customer Name: ");
                        string customer = Console.ReadLine();
                        Console.Write("Movie Name: ");
                        string movie = Console.ReadLine();
                        Console.Write("Seat Number: ");
                        string seat = Console.ReadLine();
                        Console.Write("Booking Time: ");
                        string time = Console.ReadLine();

                        list.BookTicket(id, customer, movie, seat, time);
                        break;

                    case 2:
                        Console.Write("Enter Ticket ID: ");
                        list.CancelTicket(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Enter Customer Name: ");
                        list.SearchByCustomer(Console.ReadLine());
                        break;

                    case 4:
                        Console.Write("Enter Movie Name: ");
                        list.SearchByMovie(Console.ReadLine());
                        break;

                    case 5:
                        list.DisplayAll();
                        break;

                    case 6:
                        Console.WriteLine("Total Tickets: " + list.CountTickets());
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
