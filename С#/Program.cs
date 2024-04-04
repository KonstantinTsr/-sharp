using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = Int32.Parse(input[0]);
        int M = Int32.Parse(input[1]);
        int K = Int32.Parse(input[2]);

        int[] distances = new int[N];
        input = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            distances[i] = Int32.Parse(input[i]);
        }

        int savedBatteries = 0;
        List<int> groups = new List<int>();
        int groupStart = 1;
        int groupCount = 1;

        for (int i = 0; i < N - 1; i++)
        {
            if (distances[i] + distances[i + 1] > K)
            {
                if (groupCount > 1 && groupCount <= M)
                {
                    savedBatteries += groupCount - 1;
                    groups.Add(groupStart);
                    groups.Add(groupCount);
                }
                else
                {
                    for (int j = groupStart; j < groupStart + groupCount - 1; j++)
                    {
                        savedBatteries++;
                        groups.Add(j);
                        groups.Add(1);
                    }
                }
                groupStart = i + 2;
                groupCount = 1;
            }
            else
            {
                groupCount++;
            }
        }
        if (groupCount > 1 && groupCount <= M)
        {
            savedBatteries += groupCount - 1;
            groups.Add(groupStart);
            groups.Add(groupCount);
        }
        else
        {
            for (int j = groupStart; j < groupStart + groupCount - 1; j++)
            {
                savedBatteries++;
                groups.Add(j);
                groups.Add(1);
            }
        }

        Console.WriteLine(savedBatteries);
        int groupSections = groups.Count / 2;
        Console.WriteLine(groupSections);
        for (int i = 0; i < groupSections; i++)
        {
            Console.WriteLine(groups[i * 2] + " " + groups[i * 2 + 1]);
        }
    }
}