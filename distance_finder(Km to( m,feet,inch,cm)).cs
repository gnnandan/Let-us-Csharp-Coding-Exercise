using System;

namespace distance_finder_Km_to__m_feet_inch_cm__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the source city: ");
            string sourceCity = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the distination city: ");
            string destinationCity = Convert.ToString(Console.ReadLine());

            Console.Write($"Enter the distance between {sourceCity} and {destinationCity}: ");
            double distKm = Convert.ToInt32(Console.ReadLine());

            // math logic
            double distM = distKm * 1000;
            double distFeet = distKm * 3280.84;
            double distInch = distKm * 39370.1;
            double distCent = distKm * 100000;
            Console.WriteLine($"The distance in Kilometer {distKm}");
            Console.WriteLine($"The distance in Meter {distM}");
            Console.WriteLine($"The distance in Feet {distFeet}");
            Console.WriteLine($"The distance in Inch {distInch}");
            Console.WriteLine($"The distance in Centimeter {distCent}");
        }
    }
}
