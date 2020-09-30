using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            long c;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter correct value!");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter correct value!");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your c: ");
                    c = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter correct value!");
                }
            }
            Console.WriteLine($" Your A= {a}\n Your B= {b}\n Your C= {c}");
        }
    }
}
