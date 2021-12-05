using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Library.PythonHelper;

// https://adventofcode.com/2021/day/3
// Part 2
namespace dec_03_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"puzzle-input.txt");
            print($"Read {input.Length} values");
            const int startPosition = 0;
            const bool popular = true;
            const bool unpopular = false;

            var ogr = Rating(startPosition, input.ToList(), popular);
            print(ogr[0]);
            var csr = Rating(startPosition, input.ToList(), unpopular);
            print(csr[0]);

            print("product", Convert.ToInt32(ogr[0], 2) * Convert.ToInt32(csr[0], 2));
            Console.ReadKey();
        }

        static List<string> Rating(int position, List<string> source, bool popular)
        {
            if (source.Count == 1) return source;
            var zeroes = new List<string>();
            var ones = new List<string>();
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i].Substring(position, 1) == "1")
                {
                    ones.Add(source[i]);
                }
                else
                {
                    zeroes.Add(source[i]);
                }
            }
            var popularRatings = new List<string>();
            var unpopularRatings = new List<string>();
            if (zeroes.Count > ones.Count) 
            {
                popularRatings = zeroes;
                unpopularRatings = ones;
            }
            else
            {
                popularRatings = ones;
                unpopularRatings = zeroes;
            }

            if (popular) return Rating(position + 1, popularRatings, popular);
            return Rating(position + 1, unpopularRatings, popular);
        }
    }
}
