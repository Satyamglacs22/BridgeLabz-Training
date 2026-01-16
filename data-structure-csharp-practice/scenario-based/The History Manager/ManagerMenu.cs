using System;
using System.Collections.Generic;
using System.Text;

namespace The_History_Manager
{
    internal class ManagerMenu
    {
        private ManagerUtility utility;

        public ManagerMenu()
        {
            utility = new ManagerUtility();
        }

        public void DisplayMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- BrowserBuddy Menu ---");
                Console.WriteLine("1. Visit New Page");
                Console.WriteLine("2. Go Back");
                Console.WriteLine("3. Go Forward");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Show Current Page");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        string url = Console.ReadLine();
                        utility.VisitPage(url);
                        break;

                    case 2:
                        utility.GoBack();
                        break;

                    case 3:
                        utility.GoForward();
                        break;

                    case 4:
                        utility.CloseTab();
                        break;

                    case 5:
                        utility.RestoreTab();
                        break;

                    case 6:
                        utility.ShowCurrentPage();
                        break;

                    case 0:
                        Console.WriteLine("Exiting BrowserBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
