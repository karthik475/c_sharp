using System;

namespace Methodoverloading
{
    class Program
    {
        static int addnum(int x,int y) 
        {
            return (x + y);
        }
        static double addnum(double x, double y)
        {
            return (x + y);
        }
        static void Main(string[] args)
        {
            int mynum1 = addnum(1, 2);
            double mynum2 = addnum(1.445752128568, 2.56);
            Console.WriteLine(mynum2);
            Console.WriteLine(mynum1);
        }
    }
}
