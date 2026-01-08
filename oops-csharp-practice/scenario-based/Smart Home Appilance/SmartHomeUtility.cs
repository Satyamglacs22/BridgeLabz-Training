using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home_Appilance
{
    public class SmartHomeUtility
    {
        public void Run()
        {
            List<Appliance> appliances = new List<Appliance>();

            Console.WriteLine("Enter no of Appliances in a Smart Home");
            int n = int.Parse(Console.ReadLine());


            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Chhose Appliances Type");
                Console.WriteLine("1 For Light");
                Console.WriteLine("2. For Fan");
                Console.WriteLine("3. For Ac");


                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Appliance Name");

                string name = Console.ReadLine();
                Appliance appliance;
                if (choice == 1)
                {
                    appliance = new Light();
                }
                else if (choice == 2)
                {
                    appliance = new Fan();
                }
                else if (choice == 3)
                {
                    appliance = new Ac();
                }
                else
                {
                    continue;
                }
                appliance.ApplianceName = name;
                appliances.Add(appliance);

                
            }
            Console.WriteLine("\n--- Appliance Operations ---");

            foreach (Appliance appliance in appliances)
            {
                appliance.DisplayAppliance();

                IControllable control = (IControllable)appliance;
                control.TurnOn();
                control.TurnOff();

                Console.WriteLine("--------------------------");
            }
        }
    }
}
