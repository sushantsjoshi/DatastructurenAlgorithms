using System;
using System.Linq;

namespace ConsoleApp2.Data
{
    public class MaximumCountof1CircularArray
    {
        public void Solution()
        {
            int[] arr = { 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1 };

            int maxCount = -1;
            int currentCount = 0;
            int i = 0;
            bool brk = true;

            while (true)
            {
                if (i > arr.Count())
                {
                    if (arr[i % arr.Count()] == 1) brk = true;
                    else brk = false;

                    if (i > arr.Count() * 2)
                    {
                        Console.WriteLine("Possibly all 1s");
                        break;
                    }
                }

                if (!brk) break;

                if (arr[i % arr.Count()] == 1)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount) maxCount = currentCount;
                    currentCount = 0;
                }
                i++;
            }

            if (currentCount > maxCount) maxCount = currentCount;

            Console.WriteLine(maxCount);
        }
    }
}
