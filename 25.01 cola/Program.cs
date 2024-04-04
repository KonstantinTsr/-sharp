using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01_cola
{
 using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] glasses = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите объем колы в стакане №" + (i + 1) + ":");
                glasses[i] = int.Parse(Console.ReadLine());
            }

            int minActions = 0;
            while (true)
            {
                bool isEqual = true;
                for (int i = 0; i < 9; i++)
                {
                    if (glasses[i] != glasses[i + 1])
                    {
                        isEqual = false;
                        break;
                    }
                }

                if (isEqual)
                {
                    break;
                }
                else
                {
                    int maxGlass = 0, maxIndex = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (glasses[i] > glasses[maxGlass])
                        {
                            maxGlass = i;
                            maxIndex = i;
                        }
                    }

                    glasses[maxIndex] = 0;
                    minActions++;
                }
            }

            Console.WriteLine("Минимальное количество действий: " + minActions);
        }
    }
}

