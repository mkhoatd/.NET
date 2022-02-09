// See https://aka.ms/new-console-template for more information
using System;
namespace _20Nh15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse() throw exception, TryParse() set the result value to 0 and 
            //return False if cant parse
            // int x;
            // Console.Write("Input x= ");
            // x = int.Parse(Console.ReadLine());
            // Console.WriteLine("x+1= {0}", x + 1);
            int y;
            Console.Write("Input y= ");
            int.TryParse(Console.ReadLine(), out y);
            // use out because we dont know if y has value or not
            Console.WriteLine("y+2= {0}", y + 2);
        }
    }
}