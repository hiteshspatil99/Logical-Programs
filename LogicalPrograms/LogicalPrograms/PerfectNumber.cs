using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0;
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    Console.WriteLine("{0} ", i);
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect number");
            }
        }
    }
}
