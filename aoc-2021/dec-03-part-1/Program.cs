using System;
using System.IO;
using System.Linq;
using static Library.PythonHelper;

// https://adventofcode.com/2021/day/3
// Part 1
namespace dec_03_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"puzzle-input.txt");
            var bitCount = new int[input[0].Length];
            print($"Read {input.Length} values");
            var bytes = input.Length;
            for (int i = 0; i < bytes; i++)
            {
                for (int j = 0; j < bitCount.Length; j++)
                {
                    if (input[i].Substring(j, 1) == "1")
                    {
                        bitCount[j]++;
                    }
                }
            }
            int gamma = 0;
            int bits = bitCount.Length;
            for (int k = 0; k < bits; k++)
            {
                if (bitCount[k] > bytes / 2)
                {
                    gamma += (int)Math.Pow(2, bits - k - 1);
                }
            }
            int epsilon = ~gamma & ((int)Math.Pow(2, bits)) - 1;
            print("gamma", gamma, "epsilon", epsilon, "product", gamma * epsilon);
            Console.ReadKey();
        }
    }
}
