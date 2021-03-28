using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,x,y;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            while (x != y)
            { if (x < y) 
                {
                    x = x + a;
                }
                else { y = y + b; }
            }
            Console.WriteLine(x);
        }
    }
}
