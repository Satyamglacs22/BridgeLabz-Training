using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Library_ManageMent_System
{
    

    public class LibraryUtility
    {
        public void Run()
        {
            List<LibraryItem> items = new List<LibraryItem>();

            LibraryItem book = new Book
            {
                ItemId = 1,
                Title = "C# Fundamentals",
                Author = "MS"
            };

            LibraryItem magazine = new Magazine
            {
                ItemId = 2,
                Title = "Tech Monthly",
                Author = "Editorial Team"
            };

            LibraryItem dvd = new DVD
            {
                ItemId = 3,
                Title = "Design Patterns",
                Author = "GoF"
            };

            items.Add(book);
            items.Add(magazine);
            items.Add(dvd);

            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();

                if (item is IReservable)
                {
                    IReservable reservable = (IReservable)item;
                    Console.WriteLine("Available : " + reservable.CheckAvailability());
                    reservable.ReserveItem();
                }

                Console.WriteLine("-----------------------------");
            }
        }
    }

}
