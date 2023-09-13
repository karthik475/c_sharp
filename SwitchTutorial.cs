using System;
namespace SwitchTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int switched = 78;
            int res = 0;
            switch(switched)
            {
                case 0:
                    res = 10;
                    break;
                case 2:
                    res = 20;
                    break;
                case 3:
                    res = 30;
                    break;
                case 4:
                    res = 40;
                    break;
                case 5:
                    res = 50;
                    break;
                case 6:
                    res = 100; 
                    break;
                default:
                    res=791; break;
            }
            Console.WriteLine(res);
        }
    }
}
