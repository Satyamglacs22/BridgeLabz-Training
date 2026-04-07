using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Assignment.Coding.Queue
{
    internal class HospitalTriagle
    {
        public static void Main()
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            TakeInput(map);

            SortedByPriority(map);
        }
        public static void TakeInput(Dictionary<string, int> map)
        {
            Console.WriteLine("Enter the Number of Patients");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Name of the Patient ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Priority of the Patient");
                int pr = int.Parse(Console.ReadLine());

                map[name] = pr;



            }
        }
        public static void SortedByPriority(Dictionary<string, int> map)
        {
            var mapsorted = map.OrderBy(x => x.Value);

            foreach (var e in mapsorted)
            {
                Console.WriteLine(e.Key + "  " + e.Value);
            }
        }
    }
}
