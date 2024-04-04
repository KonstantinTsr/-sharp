using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._01_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 30 элементов массива:");

            int[] array = new int[30];
            for (int i = 0; i < 30; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 10 == 5)
                {
                    sum += array[i];
                }
            }

            
            double average = sum / array.Length;

            Console.WriteLine($"Среднее арифметическое элементов, оканчивающихся на 5: {average}");
        }
    }
}
