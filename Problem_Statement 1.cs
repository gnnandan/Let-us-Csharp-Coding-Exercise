using System;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* population = 80000
             * men_population = population * 0.52 -----> 41600
             * women_population = population * 0.48 ---> 38400
             * total_literacy = population * 0.48 -----> 38400
             * literate_men = total_literacy * 0.35 ---> 13400
             * illetrate_men = men_population - 13400 -> 28200
             * literate_women = total_literacy * 0.13 -> 4992 
             * illetrate_women = women_population - 4992 -> 33408
             */

            double population, men_population, women_population, total_literacy, literate_men, illetrate_men, literate_women, illetrate_women;
            
            // population of the town
            Console.Write("Enter the population of town: ");
            population = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The population of the town: " + population);

            // men population of the towm
            men_population = population * 0.52;
            Console.WriteLine("\nThe men population of the town: " + men_population);

            //women population of the town
            women_population = population * 0.48;
            Console.WriteLine("The women population of the town: " + women_population);

            //total literacy 
            total_literacy = population * 0.48;
            Console.WriteLine("\nThe total literacy of the town: " + total_literacy);

            //men literacy 
            literate_men = total_literacy * 0.35;
            Console.WriteLine("\nThe men literacy of the town: " + literate_men);

            // men illiteracy 
            illetrate_men = men_population - literate_men;
            Console.WriteLine("The men illiteracy of the town: " + illetrate_men);

            //wowen literacy 
            literate_women = total_literacy * 0.13;
            Console.WriteLine("\nThe women literacy of the town: " + literate_women);

            //women illitracy
            illetrate_women = women_population - literate_women;
            Console.WriteLine("The women illiteracy of the town: " + illetrate_women);
        }
    }
}
