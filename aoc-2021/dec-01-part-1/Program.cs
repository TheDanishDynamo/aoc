using System;
using System.IO;
using System.Linq;

// https://adventofcode.com/2021/day/1
namespace dec_01_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"puzzle-input.txt");
            int[] reading = input.Select(int.Parse).ToArray();
            Console.WriteLine($"Read {reading.Length} values");
            int increments = 0;
            for (int i = 1; i < reading.Length; i++)
            {
                if (reading[i] > reading[i - 1])
                {
                    increments++;
                }
            }
            Console.WriteLine(increments);
            Console.ReadKey();
        }
    }
}
