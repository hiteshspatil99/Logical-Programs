using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CoupanNumber
    {
        public void Calculation(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Random random = new Random();
                int Random_generate = random.Next(999, 10000);
                if (i == 0)
                {
                    array[i] = Random_generate;
                }
                else
                {
                    int j = 0;
                    int check = 0;
                    while (j < i)
                    {
                        if (array[j] == Random_generate)
                            check = 1;
                        j++;
                    }
                    if (check == 0)
                        array[i] = Random_generate;
                    else
                        i--;
                }
            }
            Console.Write("Distinct Coupons Are:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}

            
        
