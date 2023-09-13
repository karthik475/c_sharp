using System;
namespace WhileLoopTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            while (n < 5)
            {
                n++;
            }
            Console.WriteLine(n);
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int i = 0;
            while(i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i++;
            }
        }
    }
}
