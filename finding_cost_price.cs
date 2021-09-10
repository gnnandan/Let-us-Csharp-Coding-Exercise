using System;

namespace finding_cost_price
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Formula 
             * cp = ((100 + profit%)/100) * sp
             * 
             */
            Console.Write("Enter the number of items sold: ");
            double items = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total number of items sold " + items);

            //selling price 
            Console.Write("Enter the selling price each item: ");
            double selling_price = Convert.ToDouble(Console.ReadLine());
            double sp = selling_price * items;
            Console.WriteLine("The selling price item: " + sp);

            //profit 
            Console.Write("Enter the profit percentage: ");
            double profit_percentage = Convert.ToDouble(Console.ReadLine());
            double profit = sp + sp * (profit_percentage / 100);
            Console.WriteLine("The selling price item: " + profit);

            //cost price 
            //cp = ((100 + profit %) / 100) * sp
            double cost_price = ((100 + (profit_percentage / 100)) / 100) * sp;
            Console.WriteLine("The cost price of the item is: " + cost_price);
        }
    }
}
