using System;
namespace ArrayTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 15, 65, 23, 45, 26, 17, 34, 29, 18, 65, 44, 68 };
            Console.WriteLine(ages[0] + " is the first element of the array and " + ages[11] + " is the last one");
            ages[1] = 86;
            string[] names = { "ananya", "karthik", "satish", "tejasree" };
            Console.WriteLine(names[0] + " and " + names[3] + " are female employees among all and " + names[1] + " and " + names[2] + " are male ones");
        }
    }
}
