using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество элементов, больших двух своих соседей: {count}");
        }
    }
}
