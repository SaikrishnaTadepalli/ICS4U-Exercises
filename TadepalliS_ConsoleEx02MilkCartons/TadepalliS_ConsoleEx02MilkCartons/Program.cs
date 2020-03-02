/************************************************************
    PROGRAMME	:	Console Ex02 Milk Cartons

    OUTLINE		:	This program asks the user to input amount
                    of milk and outputs the number of milk cartons 
                    needed to hold the milk, the cost of 
                    producing the milk, and the profit for producing milk.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 7, 2019
 ************************************************************/

using System;

namespace TadepalliS_ConsoleEx02MilkCartons
{
    class Program
    {
        static void Main(string[] args)
        {
            double milkProduced;
            int cartons;
            decimal production;
            decimal profit;

            Console.Title = "Console Ex02 Milk Cartons";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter Amount of Milk Produced (in Liters): ");

            milkProduced = double.Parse(Console.ReadLine());

            cartons = Convert.ToInt32(milkProduced / 3.78);
            production = Convert.ToDecimal(milkProduced * 0.38);
            profit = Convert.ToDecimal(cartons * 0.27);

            Console.WriteLine("\nNumber of Milk Cartons Needed: " + cartons);
            Console.WriteLine("Cost of Production: " + string.Format("{0:C}", production));
            Console.WriteLine("Profit : " + string.Format("{0:C}", profit));

            Console.ReadKey();
        }
    }
}
