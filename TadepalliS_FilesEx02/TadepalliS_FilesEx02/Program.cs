/************************************************************
    PROGRAMME	:	Files Ex02 Bank Account

    OUTLINE		:	This programme reads a customer's account 
                    information from a file called "customer.txt".
                    Then, it displays the data onto the console
                    along with information concerning their 
                    account balance status.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	October 04, 2019
 ************************************************************/

using System;
using System.IO;

namespace TadepalliS_FilesEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FilesEx02 Bank Account";
            Console.ForegroundColor = ConsoleColor.Cyan;

            StreamReader sr = new StreamReader("customer.txt");

            string line;
            int accountNumber = 0;
            string accountType = "";
            decimal mininumBalance = 0M;
            decimal currentBalance = 0M;

            while ((line = sr.ReadLine()) != null)
            {
                string[] characters = line.Split(" ");

                foreach (string i in characters)
                {
                    accountNumber = int.Parse(characters[0]);
                    accountType = characters[1];
                    mininumBalance = decimal.Parse(characters[2]);
                    currentBalance = decimal.Parse(characters[3]);
                }

                Console.WriteLine("\tAcct No. " + accountNumber);
                Console.WriteLine("\tAcct Type: " + accountType);
                Console.WriteLine("\tMin Bal: "  + String.Format("{0:C}", mininumBalance));
                Console.WriteLine("\tCurrent Bal: " + String.Format("{0:C}", currentBalance));

                Console.WriteLine("");

                if (mininumBalance>currentBalance)
                {
                    Console.WriteLine("\tYour current balance is " + String.Format("{0:C}", mininumBalance-currentBalance) + 
                        " below the minimum balance required.\n\tA penalty of $ 25.00 has been applied.");
                }
                else
                {
                    Console.WriteLine("\tYour current balance is " + String.Format("{0:C}", currentBalance - mininumBalance) +
                        " over the minimum balance required.");
                }

                Console.WriteLine("");
                
            }

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
