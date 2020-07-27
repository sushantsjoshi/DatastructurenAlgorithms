using System;

namespace ConsoleApp2.Data
{
    public class LCMGCMProblem
    {
        public int GCD(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;

            if (a < b) return GCD(a, b % a);
            else return GCD(b, a % b);
        }

        public int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
    }
}
