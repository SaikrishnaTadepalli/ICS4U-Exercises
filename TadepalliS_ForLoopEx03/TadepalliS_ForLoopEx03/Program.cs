/************************************************************
   PROGRAMME	:	For Loop Ex03 Every Third Number

   OUTLINE		:	This programme asks the user to enter  
                    a positive number. The program then outputs 
                    every third number from the input until -10.                    

   PROGRAMMER	:	Saikrishna Tadepalli

   DATE		:	September 24, 2019
************************************************************/

using System;

namespace TadepalliS_ForLoopEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Loop Ex03 Every Third Number";
            Console.ForegroundColor = ConsoleColor.Gray;

            int input;

            Console.Write("Enter a Number Larger than Zero: ");

            while (true) {
                if ((!(int.TryParse(Console.ReadLine(), out input))))
                {
                    Console.Write("\nInvalid Input! Enter a number greater than zero.\nPress Enter to re-enter the number!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter a Number Larger than 0: ");
                }
                else
                {
                    if (input > 0)
                    {
                        break;
                    }
                    else;
                    {
                        Console.Write("\nInvalid Input! Enter a number greater than zero.\nPress Enter to re-enter the number!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter a Number Larger than 0: ");
                    }
                }
            }

            Console.WriteLine();

            for (int i = input; i >= -10; i -= 3)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
