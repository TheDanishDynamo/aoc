using System;

namespace Library
{
    public static class PythonHelper
    {
        public static void print(params object[] p)
        {
            string result = string.Empty;
            for (int i = 0; i < p.Length - 1; i++)
            {
                result += p[i] + " "; // Add a space
            }
            result += p[^1]; // Don't add a space at the end
            Console.WriteLine(result);
        }
    }
}
