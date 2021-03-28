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
            if (x == y)
            {
                Console.Write(x);
            }
            else if (x < y) 
            { x = x + a; 
            }
            else { y = y + b; }
        }
    }
}
