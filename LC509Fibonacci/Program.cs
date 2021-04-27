using System;

namespace LC509Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFib(6));
        }

        public static int GetFib(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            for (int i = 1; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }
    }
}
