using System;

namespace sum_of_first_and_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, first, last;
            Console.Write("Enter 4 digit number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The 4 digit number: {num}");

            // remember the logic
            first = (num / 1000) % 10;
            last = (num % 10);
            Console.WriteLine($"The sum of {first} and {last} is {first + last}");
        }
    }
}
