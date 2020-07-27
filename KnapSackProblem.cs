using System;

namespace ConsoleApp2.Data
{
    public class KnapSackProblem
    {
        public KnapSackProblem()
        {
            int[] value = { 60, 100, 120 };
            int[] weight = { 10, 20, 30 };
            int W = 50;

            Console.WriteLine(RecursiveKP(weight, value, W, weight.Length - 1));
            Console.WriteLine(DPKnapSack(weight, value, W));
        }

        public int RecursiveKP(int[] weight, int[] value, int W, int n)
        {
            if ((n < 0) || (W == 0)) return 0;

            if (W >= weight[n])
            {
                return Math.Max(RecursiveKP(weight, value, W - weight[n], n - 1) + value[n], RecursiveKP(weight, value, W, n - 1));
            }

            return RecursiveKP(weight, value, W, n - 1);
        }

        public int DPKnapSack(int[] weight, int[] value, int W)
        {
            int[][] arr = new int[W + 1][];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new int[value.Length];

            for (int w = 0; w < W + 1; w++)
            {
                for (int v = 1; v < value.Length; v++)
                {
                    if (w == 0)
                        arr[w][v] = 0;
                    else
                    {
                        if (w >= weight[v])
                        {
                            arr[w][v] = Math.Max(arr[w - weight[v]][v - 1] + value[v], arr[w][v - 1]);
                        }
                        else
                        {
                            arr[w][v] = arr[w][v - 1];
                        }
                    }
                }
            }

            return arr[W][value.Length - 1];
        }
    }
}
