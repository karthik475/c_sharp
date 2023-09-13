using System;
namespace ForLoopTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine(k + " is the value of i");
            for ( int i = 1; i < 5; i++)
            {
                int p = i + 1;
                Console.WriteLine(i + " is the next value of i that is one less than " + p);
            }
            string[] names = { "dane", "jane", "kane", "rane" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("value on index "+i+" is equal to " +names[i]);
            }
        }
    }
}
