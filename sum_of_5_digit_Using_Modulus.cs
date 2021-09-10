using System;

namespace sum_of_5_digit_Using_Modulus
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 5 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // logic should remember
            double sum = (num % 10) + (num / 10) % 10 + (num / 100) % 10 + (num / 1000) % 10 + (num / 10000) % 10;
            Console.WriteLine($"The sum of {num} is:{sum}");
        }
    }
}
