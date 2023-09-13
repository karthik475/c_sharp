using System;
namespace Csharp
{
    class ForEachTutorial
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Audi", "Ferrari", "Maserrati", "Mercedes","Mini","Toyota","Morris Garrage","Cadillac","Buggati","Ford","Mustang","Nissan","Volvo","Lamborghini" };
            //cars = new string[] { "Volvo" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Array.Sort(cars);
            Console.WriteLine("Number of cars are "+ cars.Length);
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
