using System;

namespace Groceries
{
    public class ProductMain
    {
        public static void Main()
        {
            ProductUtility utility = new ProductUtility();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect Role:");
                Console.WriteLine("1. User");
                Console.WriteLine("2. Admin");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.DisplayProducts();
                        utility.BuyProducts();
                        break;

                    case 2:
                        bool adminExit = false;
                        while (!adminExit)
                        {
                            Console.WriteLine("\nAdmin Menu:");
                            Console.WriteLine("1. Add Products");
                            Console.WriteLine("2. View Products");
                            Console.WriteLine("0. Back");

                            int adminChoice = int.Parse(Console.ReadLine());

                            switch (adminChoice)
                            {
                                case 1:
                                    utility.AddProducts();
                                    break;
                                case 2:
                                    utility.DisplayProducts();
                                    break;
                                case 0:
                                    adminExit = true;
                                    break;
                            }
                        }
                        break;

                    case 0:
                        exit = true;
                        break;
                }
            }
        }
    }
}
