/************************************************************
    PROGRAMME	:	Console Ex03 Power Bar Sale

    OUTLINE		:	This programme asks the user to enter the 
                    number of cases sold and Display cases sold, 
                    price per case, money made, money donated to 
                    SAC with relevant ones formatted to currency.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 7, 2019
 ************************************************************/


using System;

namespace TadepalliS_ConsoleEx03PowerBarSale
{
    class Program
    {
        static void Main(string[] args)
        {

            int cases;
            decimal pricePerBar;

            Console.Title = "Power Bar Sales";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nSATEC Computer Club: Power Bar Sale\n");
            Console.Write("Enter Number of Cases Sold: ");

            cases = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Sale Prices of Each Bar: $ ");
            pricePerBar = decimal.Parse(Console.ReadLine());

            decimal revenue = pricePerBar * cases * 12;
            decimal profit = revenue - cases * 5;
            decimal donated = profit / 10;
            decimal netProfit = profit - donated;

            Console.WriteLine("\nNumber of Boxes Sold: " + cases);

            Console.WriteLine("Total Price of Cases Bought: " + string.Format("{0:C}", cases * 5));

            Console.WriteLine("Number of Bars Sold: " + cases * 12);
            Console.WriteLine("Sale Price Per Bar: " + string.Format("{0:C}", pricePerBar));

            Console.WriteLine("Total Revenue: " + string.Format("{0:C}", revenue));
            Console.WriteLine("Total Profit: " + string.Format("{0:C}", profit));

            Console.WriteLine("To be Paid to SAC: " + string.Format("{0:C}", donated));
            Console.WriteLine("Total Net Profit: " + string.Format("{0:C}", netProfit));


            Console.ReadKey();
        }
    }
}
