/************************************************************
    PROGRAMME	:	Console Ex04 COOKIES

    OUTLINE		:	This program asks the user to enter the 
                    total number of cookies and displays the
                    number of cookies and boxes needed as well 
                    as the left over quantities of boxes and cookies

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 7, 2019
 ************************************************************/

using System;

namespace TadepalliS_ConsoleEx04Cookies
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalCookies;
            double boxesCount;
            double containerCount;

            Console.Title = "COOKIES!";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\n\tEnter Total Number of Cookies: ");
            totalCookies = int.Parse(Console.ReadLine());;

            boxesCount = Math.Floor(totalCookies / 24);
            containerCount = Math.Floor(boxesCount / 75);

            Console.WriteLine("\n\tNumber of Boxes Required: " + boxesCount);
            Console.WriteLine("\tNumber of Containers Required: " + containerCount);
            Console.WriteLine("\n\tNumber of Leftover Cookies: " + (totalCookies % 24));
            Console.WriteLine("\tNumber of Leftover Boxes: " + (boxesCount % 75));

            Console.ReadKey();
        }
    }
}
