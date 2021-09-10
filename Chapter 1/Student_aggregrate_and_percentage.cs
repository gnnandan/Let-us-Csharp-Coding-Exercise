using System;

namespace Student_aggregrate_and_percentage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Students Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Enter {name}'s Marks One By One");

            Console.Write($"Enter {name}'s Subject 1 marks: ");
            int sub1Marks = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Enter {name}'s Subject 2 marks: ");
            int sub2Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter {name}'s Subject 3 marks: ");
            int sub3Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter {name}'s Subject 4 marks: ");
            int sub4Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter {name}'s Subject 5 marks: ");
            int sub5Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter {name}'s Subject 6 marks: ");
            int sub6Marks = Convert.ToInt32(Console.ReadLine());

            double aggregrate = sub1Marks + sub2Marks + sub3Marks + sub4Marks + sub5Marks + sub6Marks;
            Console.WriteLine($"Enter {name}'s aggregrate marks = {aggregrate}");

            float percentage = (((sub1Marks + sub2Marks + sub3Marks + sub4Marks + sub5Marks + sub6Marks) * 100) / 600);
            Console.WriteLine($"Enter {name}'s percentage marks = {percentage}%");
        }
    }
}
