using System;

namespace ConsoleApp2.Data
{
    public class LongestPallindrome
    {
        public void longestpallindromesubstring()
        {
            var str = "jacknjillandllijnkcaj";
            int maxLength = 0;
            int maxStart = 0;
            for (int i = 1; i < str.Length; i++)
            {
                int low = i;
                int high = i + 1;
                int currentStart = low;
                int currentmax = 0;
                while (low >= 0 && high < str.Length && str[low] == str[high])
                {
                    currentStart = low;
                    currentmax = high - low + 1;
                    low--;
                    high++;
                }

                if (currentmax > maxLength)
                {
                    maxStart = currentStart;
                    maxLength = currentmax;
                }

                low = i - 1;
                high = i + 1;
                currentStart = low;
                currentmax = 0;

                while (low >= 0 && high < str.Length && str[low] == str[high])
                {
                    currentStart = low;
                    currentmax = high - low + 1;
                    low--;
                    high++;
                }

                if (currentmax > maxLength)
                {
                    maxStart = currentStart;
                    maxLength = currentmax;
                }
            }

            Console.WriteLine(str.Substring(maxStart, maxLength));

        }
    }
}
