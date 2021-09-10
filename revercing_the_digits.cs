using System;

namespace revercing_the_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Reversing {num}");
            // remember the logic
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;
            int e = (num / 10000) % 10;
            Console.WriteLine($"After Reversing: " + a + b + c + d + e);
        }
    }
}
