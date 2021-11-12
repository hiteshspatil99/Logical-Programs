using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2.Perfect Number \n 3.Prime Number \n 4.Reverse a Number \n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber number = new PerfectNumber();
                        number.Perfect();
                        break;
                    case 3:
                        PrimeNumber num = new PrimeNumber();
                        num.Prime();
                        break;
                    case 4:
                        ReversealNumber rev = new ReversealNumber();
                        rev.Reverse();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
