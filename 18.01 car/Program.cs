using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01_car
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string road = "nnnnnnn_nnnnnn_nnnnn";
            int hits = 0;

            foreach (char c in road)
            {
                if (c == 'n')
                {
                    hits++;
                }

                if (hits > 15)
                {
                    Console.WriteLine("Car Dead");
                    return;
                }
            }

            Console.WriteLine("Woohoo!");
        }
    }
}
