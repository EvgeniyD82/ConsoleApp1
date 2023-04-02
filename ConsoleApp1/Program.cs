using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }
         public static void Task1()
            {
                double pi = Math.PI;
                Console.WriteLine("vvedi radius r=");
                string radius = Console.ReadLine();
                Console.WriteLine("vvedi visotu h=");
                string visota = Console.ReadLine();
                double r = Convert.ToDouble(radius);
                double h = Convert.ToDouble(visota);
                double S = 2 * pi * r * (r + h);
                double V = 2 * pi * r * h;
            Console.WriteLine("S=" + Math.Round(S, 2)); 
            Console.WriteLine("V=" + Math.Round(V, 2));
        }
        public static void Task2()
        {
            Console.WriteLine("Vvedite chislo:");
            string numberSTR = Console.ReadLine();
            int number = int.Parse(numberSTR);
            if ((number > 5) && (number < 10))
            {
                Console.WriteLine("The number in 5-10");
            }
            else {
                Console.WriteLine("The unknown number");
            }
        }

        public static void Task3()
        {
            double result = 0;
            Console.WriteLine("Vvedite summu vklada:");
            int deposit = int.Parse(Console.ReadLine());
            if (deposit < 100)
            {
                result = deposit * 0.05;
                    }
            else if ((deposit >= 100) && (deposit <= 200))
            {
                result = deposit * 0.07;
            }
            else if (deposit > 200)
            {
                result = deposit * 0.1;
            }
            double finalresult = deposit + result;
            Console.WriteLine("Result ="+finalresult);
        }
        public static void Task4()
        {
            Console.WriteLine("Vvedite chislo:");
            int a = int.Parse(Console.ReadLine());
            if ((a%2 == 0) && (a%3 == 0))
            {
                Console.WriteLine("chislo kratno 2 i 3");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("chislo kratno 2");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("chislo kratno 3");
            }
            else { Console.WriteLine("chislo ne kratno ni 2 i ne 3"); }
        }
    }
    
}