using System;

namespace finding_area_perimeter_and_circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaOfRectangle = length * breadth;
            double perimeterOfRectangle = 2 * (length + breadth);
            double areaOfCircle = 3.14 * radius * radius;
            double circumferenceOfCircle = 2 * 3.14 * radius;

            Console.WriteLine($"Rectangle area: {areaOfRectangle} & Reactangle Perimeter: {perimeterOfRectangle}");
            Console.WriteLine($"Circle area: {areaOfCircle} & Circumference of circle: {circumferenceOfCircle}");
        }
    }
}
