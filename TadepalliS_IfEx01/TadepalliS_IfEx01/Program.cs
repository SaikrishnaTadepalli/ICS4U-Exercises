/************************************************************
    PROGRAMME	:	IF/Switch Ex01 Month Number

    OUTLINE		:	This programme asks the user to input a month
                    number and it outputs the name of the entered
                    month number and the number of days that month 
                    has.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 10, 2019
 ************************************************************/

using System;

namespace TadepalliS_IfEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MONTH OF YEAR";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] months = {"January", "February","March","April","May","June",
                "July","August","September","October","November","December"};
            string[] days = { "31","28","31","30","31","30","31","31","30","31","30","31"};

            string input;
            int month;

            Console.Write("\tEnter a Month Number(1-12): ");
            input= (Console.ReadLine());
            if (int.TryParse(input, out month))
            {
                if (month > 0 & month < 13)
                {
                    Console.Write("\n\tMonth Number " + month + " is " + months[month - 1] + ".\n\tIt has " + days[month - 1] + " days.");
                }
                else
                {
                    Console.Write("\n\tInvalid Input! You Must Enter a Number Between 1 and 12!");
                }
            }
            else {

                Console.Write("\n\tError! Blank or non-numeric input!");
            }




            Console.ReadKey();
        }
    }
}
