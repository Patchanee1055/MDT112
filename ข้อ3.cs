using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int boxNumb1, boxNumb2, boxNumb3, Bucket, pick;
            Console.WriteLine("Input bucket1's box ");
            boxNumb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input bucket2's box ");
            boxNumb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input bucket3's box ");
            boxNumb3 = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("A's turn");
                Console.WriteLine("bucket1 = {0}", boxNumb1);
                Console.WriteLine("bucket2 = {0}", boxNumb2);
                Console.WriteLine("bucket3 = {0}", boxNumb3);
                Console.Write("select bucket:");
                Bucket = int.Parse(Console.ReadLine());
                switch (Bucket)
                {
                    case 1:
                        Console.WriteLine("Pick out the box");
                        pick = int.Parse(Console.ReadLine());
                        if (pick <= 2 && pick > 0)
                        {
                            boxNumb1 = boxNumb1 - pick;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Pick out the box");
                        pick = int.Parse(Console.ReadLine());
                        if (pick <= 2 && pick > 0)
                        {
                            boxNumb2 = boxNumb2 - pick;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Pick out the box");
                        pick = int.Parse(Console.ReadLine());
                        if (pick <= 2 && pick > 0)
                        {
                            boxNumb3 = boxNumb3 - pick;
                        }
                        break;
                }
                if (boxNumb1 == 0 && boxNumb2 == 0 && boxNumb3 == 0)
                {
                    Console.WriteLine("The winner is B");
                }
                else
                {
                    Console.WriteLine("B's turn");
                    Console.WriteLine("bucket1 = {0}", boxNumb1);
                    Console.WriteLine("bucket2 = {0}", boxNumb2);
                    Console.WriteLine("bucket3 = {0}", boxNumb3);
                    Console.Write("select bucket:");
                    Bucket = int.Parse(Console.ReadLine());
                    switch (Bucket)
                    {
                        case 1:
                            Console.WriteLine("Pick out the box");
                            pick = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (pick <= 2 && pick > 0)
                            {
                                boxNumb1 = boxNumb1 - pick;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Pick out the box");
                            pick = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (pick <= 2 && pick > 0)
                            {
                                boxNumb2 = boxNumb2 - pick;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Pick out the box");
                            pick = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (pick <= 2 && pick > 0)
                            {
                                boxNumb3 = boxNumb3 - pick;
                            }
                            break;
                    }
                    if (boxNumb1 == 0 && boxNumb2 == 0 && boxNumb3 == 0)
                    {
                        Console.WriteLine("The winner is A");
                    }
                }
            } while (boxNumb1 != 0 || boxNumb2 != 0 || boxNumb3 != 0);
            Console.ReadLine();

        }
    }
}
