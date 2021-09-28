using System;

namespace BitwiseMethods
{
    class Program
    {
        static bool Contains(int mask, int el)
        {
            return (mask & (1 << el)) != 0;
        }

        static void Insert(ref int mask, int el)
        {
            mask |= (1 << el);
        }

        static void Remove(ref int mask, int el)
        {
            mask &= ~(1 << el);
        }

        static void Change(ref int mask, int el)
        {
            mask ^= (1 << el);
        }

        static void Main(string[] args)
        {
            int a = 0;
            Insert(ref a, 0);
            Insert(ref a, 3);
            Insert(ref a, 5);
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
        }
    }
}
