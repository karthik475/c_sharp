using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.Write("First number: ");
                long first = long.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                long second = long.Parse(Console.ReadLine());
                Console.Write("Operator: ");

                string Operator = Console.ReadLine();
                long result = 0;

                switch (Operator)
                {
                    case "+":
                        long sum = (first + second);
                        result = sum;
                        break;
                    case "-":
                        long sub = (first - second);
                        result = sub;
                        break;
                    case "*":
                        long mul = (first * second);
                        result = mul;
                        break;
                    case "/":
                        long div = (first / second);
                        result = div;
                        break;

                }
                Console.WriteLine(result);
                Console.WriteLine("Do you want to continue yes/no: ");
                value =Console.ReadLine();
            } while (value == "yes" || value == "Yes" || value == "YES");
        }
    }
}
