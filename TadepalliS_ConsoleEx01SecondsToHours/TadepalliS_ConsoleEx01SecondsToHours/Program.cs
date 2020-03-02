/************************************************************
    PROGRAMME	:	Console Ex01 Seconds to hours

    OUTLINE		:	This programme asks the user for  total seconds and 
				    outputs it in hours, minutes and seconds.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 7, 2019
 ************************************************************/

using System;

namespace TadepalliS_ConsoleEx01SecondsToHours
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Seconds to Hours";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int seconds;
            int minutes;
            int hours;

            Console.Write("Enter Number of Seconds: ");

            seconds = int.Parse(Console.ReadLine());
            hours = seconds / 3600;

            seconds -= 3600 * hours;
            minutes = seconds / 60;

            seconds -= 60 * minutes;

            Console.WriteLine("\nTotal Time (Hours:Min:Sec): " + 
                hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2") + "\n");

            Console.ReadKey();
        }
    }
}
