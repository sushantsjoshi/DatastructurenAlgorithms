using System;

namespace ConsoleApp2.Data
{
    public class CoinChangeProblem
    {
        public void CoinChange()
        {
            int[] coins = { 1, 2, 5, 10 };

            int[][] arr = new int[4][];

            int change = 7;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[change + 1];
            }

            for (int x = 0; x < arr.Length; x++)
            {
                for (int y = 1; y < change + 1; y++)
                {
                    arr[x][y] = int.MaxValue;

                    if (y % coins[x] == 0)
                    {
                        arr[x][y] = y / coins[x];
                    }

                    if (x > 0)
                    {
                        arr[x][y] = Math.Min(arr[x - 1][y], arr[x][y]);
                    }

                    if (y > 1)
                    {
                        arr[x][y] = Math.Min(arr[x][y - 1] + 1, arr[x][y]);
                    }

                    if (y > coins[x])
                    {
                        arr[x][y] = Math.Min(arr[x][y], arr[x][y - coins[x]] + 1);
                    }
                }

            }

        }
    }
}
