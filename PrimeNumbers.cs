using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public class PrimeNumbers
    {
        public void PrimeNumbersTillNNumbers()
        {
            var n = 200;
            n++;
            bool[] arr = new bool[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i * i < n; i++)
            {
                int p = i;
                if (arr[p])
                {
                    p += i;
                    while (p < n)
                    {
                        arr[p] = false;
                        p += i;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                if (arr[i])
                    Console.WriteLine($"Next Prime No is {i}");
        }
    }
}
