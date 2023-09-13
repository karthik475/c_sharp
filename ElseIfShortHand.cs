using System;
namespace ElseIfShortHand
{
    class Program
    {
        static void Main(string[] args)
        {
            int k =  Int32.Parse(Console.ReadLine());
            /*if (k < 16)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }*/
            string result = (k < 16) ? "Good Day" : "Good Evening";
            Console.WriteLine(result);
        }
    }
}
