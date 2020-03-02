/************************************************************
   PROGRAMME	:	For Loop Ex02 Odd Numbers

   OUTLINE		:	This programme asks the user to input a number 
                    from which the program output all odd numbers 
                    from 0 to the entered number

   PROGRAMMER	:	Saikrishna Tadepalli

   DATE		:	September 24, 2019
************************************************************/

using System;

namespace TadepalliS_ForLoopEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Loop Ex02: Odd Numbers";
            Console.ForegroundColor = ConsoleColor.Gray;
            
            int input;

            Console.Write("\n\tEnter a Positive Number: ");

            input = int.Parse(Console.ReadLine());

            Console.Write("\n\n");

            for (int i = 1; i <= input; i += 2)
            {
                Console.Write("\t"+ i);
            }

            Console.ReadKey();
        }
    }
}
