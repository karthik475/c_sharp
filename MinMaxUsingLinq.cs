using System;
using System.Linq;

namespace MinMAxUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());

        }
    }
}
