// See https://aka.ms/new-console-template for more information
using System;
namespace _20Nh15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("DUT");
            // Console.Write("ITF");
            // int x = 1, y = 2;
            // Console.WriteLine("x= " + x);
            // Console.WriteLine("x= {0}", x);
            // Console.WriteLine("x= {0}, y= {1}", x, y);
            // Console.WriteLine("x= {0}, y= {1}", y, x);
            // int x;
            // Console.Write("Input x= ");
            // x = Console.Read();
            // Console.WriteLine("x= {0}", x);
            // string y;
            // Console.Write("Input y= ");
            // y = Console.ReadLine();
            // Console.WriteLine("y= {0}", y);
            // int x = 100;
            // object obj = new object(); //init new object, give a empty storage in heap
            // Console.WriteLine(obj);
            // obj = x; //boxing
            // Console.Write(x);
            //unboxing
            object obj; //reference type
            int x = 100;
            obj = x; //boxing
            int y = (int)obj; //unboxing, create new variable y, copy obj value in heap to y storage in stack
            Console.WriteLine(y);
        }
    }
}