using System;

namespace adding_newnumber_to_existing_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a, b, c, d, e;
            a = (num % 10) + 1;
            b = (num / 10) % 10 + 1;
            c = (num / 100) % 10 + 1;
            d = (num / 1000) % 10 + 1;
            e = (num / 10000) % 10 + 1;
            Console.WriteLine("The digits before adding 1 to each digit: "+ num);
            Console.WriteLine("The digits after adding 1 to each digit: "+ e + d + c + b + a);
        }
    }
}
