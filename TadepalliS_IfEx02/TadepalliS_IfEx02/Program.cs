/************************************************************
    PROGRAMME	:	IF/Switch Ex02 Shipping Cost

    OUTLINE		:	This programme asks the user to input the 
                    amount of total purchases and it outputs
                    the correspondingéassociated shipping charge

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 10, 2019
 ************************************************************/

using System;

namespace TadepalliS_IfEx02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "SHIPPING CHARGES";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string inStr;
            decimal input;

            Console.Write("\tEnter Total Putchases: ");
            inStr = Console.ReadLine();

            if (decimal.TryParse(inStr, out input))
            {
                input = decimal.Parse(inStr);

                if (input <= 0)
                {

                    Console.Write("\n\tError! Total Purchases must be greater than zero!");
                }
                else if (input > 0.00M & input <= 250M)
                {
                    input = 5.00M;

                    Console.Write("\tShipping Charge: " + input.ToString("C"));
                }
                else if (input >= 250.01M & input <= 500M)
                {
                    input = 8.00M;

                    Console.Write("\tShipping Charge: " + input.ToString("C"));
                }
                else if (input >= 500.01M & input <= 1000M)
                {
                    input = 10.00M;

                    Console.Write("\tShipping Charge: " + input.ToString("C"));
                }
                else if (input >= 1000.01M & input <=
                    5000M)
                {
                    input = 15.00M;

                    Console.Write("\tShipping Charge: " + input.ToString("C"));
                }
                else if (input > 5000M)
                {
                    input = 20.00M;

                    Console.Write("\tShipping Charge: " + input.ToString("C"));
                }

            }
            else {
                Console.WriteLine("\n\tError! Blank or non-numeric input!");
            }

            Console.ReadKey();
        }
    }
}
