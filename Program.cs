// See https://aka.ms/new-console-template for more information
using System;
namespace _20Nh15
{
    class Program
    {
        public static void HV(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static void Add(out int c)
        {
            c = 5;
        }
        static void Main(string[] args)
        {
            int t;
            int m = 1, n = 2;
            HV(ref m, ref n);
            Console.WriteLine("m={0}, n={1}", m, n);
            Add(out t);
            Console.WriteLine("t={0}", t);
        }
    }
}