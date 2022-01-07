using System;

namespace Recursion
{
    class Program
    {
        static int Add(int x, int y)
        {
            return (x+y);
        }

        static int Subtract(int x, int y)
        {
            return Add(x, -y);
        }

        static int Multiply(int x, int y)
        {
            if (y > x)
                return Multiply(y, x);
            
            int res = 0;

            for(int i = 0; i < y; i++)
                res = Add(res, x);
            
            return res;
        }

        static int Divide(int x, int y)
        {
            int res = 0;

            for(int i = x; i>0; i = Subtract(i, y))
                res = Add(res, 1);
            
            return res;
        }

        static int Factorial(int x)
        {
            if (x == 1)
                return 1;
            
            return x * Factorial(x - 1);
        }
        static void Main()
        {
            int n, m;

            Console.WriteLine("Insert n and m");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("#########");
            Console.WriteLine(Add(n, m));
            Console.WriteLine(Subtract(n, m));
            Console.WriteLine(Multiply(n, m));
            Console.WriteLine(Divide(n, m));
            Console.WriteLine(Factorial(n));
            Console.WriteLine(Factorial(m));
        }
    }
}