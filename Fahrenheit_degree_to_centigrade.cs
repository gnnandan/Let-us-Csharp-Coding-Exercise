using System;

namespace Fahrenheit_degree_to_centigrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your city's temprature in °F:");
            double f_degree = Convert.ToDouble(Console.ReadLine());
            double c_degree = (f_degree - 32) * 5 / 9;
            Console.WriteLine($"Your city's temprature is converted from {f_degree}°F to {c_degree}°C");
        }
    }
}
