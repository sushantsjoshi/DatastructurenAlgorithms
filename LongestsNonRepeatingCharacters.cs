using System;

namespace ConsoleApp2.Data
{
    public class LongestsNonRepeatingCharacters
    {
        public void longestnonrepeatingcharacters()
        {
            var str = "hilonhil";

            int[] arr = new int[26];

            for (int i = 0; i < 26; i++) arr[i] = -1;
            int current = 0;
            int maxLength = 0;
            int length = 0;
            int maxStart = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (arr[str[i] - 'a'] == -1)
                {
                    arr[str[i] - 'a'] = i;
                    length++;
                }
                else
                {
                    if (arr[str[i] - 'a'] < current)
                    {
                        arr[str[i] - 'a'] = i;
                        length++;
                    }
                    else
                    {
                        if (length > maxLength)
                        {
                            maxLength = length;
                            maxStart = current;
                        }

                        length = 0;
                        current = i;
                        arr[str[i] - 'a'] = i;
                    }
                }
            }

            if (length > maxLength)
            {
                maxLength = length;
                maxStart = current;
            }

            Console.WriteLine(str.Substring(maxStart, maxLength));
        }
    }
}
