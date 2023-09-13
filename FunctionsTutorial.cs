using System;

namespace FunctionTutorial
{
    class Program
    {
        public static void printnumber(int number)
        {
            Console.WriteLine(number);
        }
        public static int squared(int x)
        {
            int y = x * x;
            return y;
        }
        public static Boolean isbigger(int frst,int sec)
        {
            Boolean temp = frst < sec;
            return temp;
        }
        
        static void Main(string[] args)
        {
            int temp = 0;
            Console.WriteLine(squared(5));
            printnumber(temp);
            Console.WriteLine(isbigger(100, 20));
        }
    }
}
