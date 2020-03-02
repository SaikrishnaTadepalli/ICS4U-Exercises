/************************************************************
    PROGRAMME	:	IF/Switch Ex04 Phone Number

    OUTLINE		:	This programme asks the user to input a string
                    of characters containing letters, and it outputs
                    the phone number that the letters correspond to

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 10, 2019
 ************************************************************/

using System;

namespace TadepalliS_IfEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PHONE NUMBERS";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] letters = {"0","1","ABC","DEF","GHI","JKL","MNO","PQRS","TUV","WXYZ" };
            bool contained;
            string input;
            string output = "";

            Console.Write("\n\tEnter a String as a Phone Number: ");
            input = Console.ReadLine();

            foreach (char i in input) {
                contained = false;

                char.ToUpper(i);

                for (int num = 0; num <= 9; num++) {
                    if (letters[num].Contains(char.ToUpper(i))) {
                        output += (numbers[num]);
                        contained = true;
                    }
                }

                if (contained == false) {
                    output += i;
                }
            }

            Console.WriteLine("\t"+ output);
            Console.ReadKey();
        }
    }
}
