/************************************************************
    PROGRAMME	:	For Loop Ex01 Even Numbers

    OUTLINE		:	This programme outputs all even numbers from 100 to 0.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 24, 2019
 ************************************************************/

using System;

namespace TadepalliS_ForLoopEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FOR EX01 Even Numbers";
            Console.ForegroundColor = ConsoleColor.Cyan;
            // example shows 0 to 100 , all even numbers
            /*
             code for 0 to 100 all even:

             for (int i = 0; i <= 100; i += 2) {
                 Console.Write(i+ " ");
             }

             */
            // document says 100 to 0, all even  numbers
            for (int i = 100; i >=0; i -= 2)
            {
                Console.Write(i + " ");
            }
                Console.ReadKey();
        }
    }
}
