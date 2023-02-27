using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        const int ARRAY_SIZE = 1000000;

        int[] array = new int[ARRAY_SIZE];
        int sum = 0;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < 1000000; i++)
        {
            for (int j = 0; j < ARRAY_SIZE; j++)
            {
                sum += array[j];
                array[j] = sum;
            }
        }

        stopwatch.Stop();
        Console.WriteLine("Time taken: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

        Console.ReadLine();
    }
}