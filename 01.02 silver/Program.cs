using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int M = Int32.Parse(input[0]);
        int K = Int32.Parse(input[1]);
        int W = Int32.Parse(input[2]);

        int coins = 0;

        while (M >= K)
        {
            int newCoins = M / K;
            coins += newCoins;
            int leftoverSilver = M - (newCoins * K);
            M = M - (newCoins * K) + newCoins * W;
        }

        Console.WriteLine(coins);
    }
}
