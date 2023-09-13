using System;
using System.Linq;
namespace TwoDArrayTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine(numbers[0, 1]);
        }
    }
}
