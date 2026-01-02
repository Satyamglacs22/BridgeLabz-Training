using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    public  class Menu
    {
        public static void Main()
        {

            Menu m = new Menu();


            string[,] menu = new string[10, 2]
        {
            { "Veg Burger", "120" },
            { "Cheese Pizza", "280" },
            { "Veg Pasta", "200" },
            { "French Fries", "150" },
            { "Veg Sandwich", "130" },
            { "Paneer Roll", "180" },
            { "Veg Biryani", "250" },
            { "Masala Dosa", "140" },
            { "Cold Coffee", "110" },
            { "Tea", "40" }
        };

            bool check = false;
                while (!check)
                {
                Console.WriteLine("Enter 1 For Menu");
                Console.WriteLine("Enter 2 For Choosing Items");
                Console.WriteLine("Enter 3 For Termination ");

                int iChoice = int.Parse(Console.ReadLine());
                    switch (iChoice)
                    {
                        case 1:
                        //Console.WriteLine("Enter 1 For Menu");
                            m.DisplayMenu(menu);
                            break;

                        case 2:
                        //Console.WriteLine("Enter 2 For Choosing Items");
                        m.GetItemByIndex(menu);
                            break;

                        case 3:
                        //Console.WriteLine("Enter 3 For Termination ");
                            check = true;
                            break;


                    
                }
            }

        }
        public void DisplayMenu(string[,] menu)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{menu[i, 0]}         --------------          {menu[i, 1]}");
            }
        }
        public void GetItemByIndex(string[,] menu)

        {
            Console.WriteLine("Enter Index to Get Item");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{menu[n - 1, 0]}         --------------         {menu[n - 1, 1]}");
        }

    }
}
