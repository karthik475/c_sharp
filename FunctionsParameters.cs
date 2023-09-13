using System;
namespace Csharp
{
    class FunctionsParameters
    {
        /*public static void Mymethod(string fname, int age)
        {
            Console.WriteLine(fname + " Smith's " + "age is " + age);
        }
        static void Main(string[] args)
        {
            Mymethod("Rick",45);
            Mymethod("Henry", 49);
            Mymethod("Sean",26);
        }
        */
        public static void Mymethod(string x, string y, string z)
        {
            Console.WriteLine("the youngest child is " + x + " Tenneson");
        }
        static void Main(string[] args)
        {
            Mymethod(x: "Gwen", y: "Ben", z : "Max");
        }
    }
}
