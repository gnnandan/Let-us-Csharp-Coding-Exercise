using System;

namespace sample_code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the salary: ");
            double basic_salary = Convert.ToDouble(Console.ReadLine());
            double allowance = basic_salary * 0.04 + basic_salary * 0.02;
            double total_salary = basic_salary + allowance;
            Console.WriteLine($"Ramesh's Basic Salary is: {basic_salary}");
            Console.WriteLine($"Ramesh's Gross Salary is: {total_salary}");
        }
    }
}
