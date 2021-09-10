using System;

namespace interchanging_order_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Enter the num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //logic 1
            // num1 = num1 * num2;
            // num2 = num1 / num2;
            // num1 = num1 / num2;

            //logic 2
            Console.WriteLine($"Before swapping: {num1} & {num2} ");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping: {num1} & {num2} ");
        }
    }
}
