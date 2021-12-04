using System;
using System.IO;
using System.Linq;
using static Library.PythonHelper;

// https://adventofcode.com/2021/day/1
// Part 2
namespace dec_01_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var input = File.ReadAllLines(@"puzzle-input-example.txt");
#else
            var input = File.ReadAllLines(@"puzzle-input.txt");
#endif
            int[] reading = input.Select(int.Parse).ToArray();
#if DEBUG
            print($"Read {reading.Length} values");
            print("Input:", string.Join(" ", reading));
#endif
            int increments = 0;
            for (int i = 4; i <= reading.Length; i++)
            {
                var firstWindowSum = reading[i - 4] + reading[i - 3] + reading[i - 2];
                var secondWindowSum = reading[i - 3] + reading[i - 2] + reading[i - 1];
#if DEBUG
                print("------");
                print("First Window:", reading[i - 4], reading[i - 3], reading[i - 2], "Sum:", firstWindowSum);
                print("Second Window:", reading[i - 3],reading[i - 2],reading[i - 1], "Sum:", secondWindowSum);
#endif
                if (secondWindowSum > firstWindowSum)
                {
                    increments++;
#if DEBUG
                    print("(increment)");
#endif
                }
                else
                {
#if DEBUG
                    print("(decrement)");
#endif
                }
            }
            print("Result:", increments);
            Console.ReadKey();
        }
    }
}
