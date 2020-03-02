/************************************************************
   PROGRAMME	:	For Loop Ex04 Nested

   OUTLINE		:	This programme outputs the following:
                    
                    *
                    ++
                    ***
                    ++++
                    *****

   PROGRAMMER	:	Saikrishna Tadepalli

   DATE		:	September 24, 2019
************************************************************/

using System;

namespace TadepalliS_ForEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Ex04: Nested Loops";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string output= "";
            int i;
            int k = 0;

            for (i = 0; i < 5; i++)
            {
                output = "";
                k++;             
                for (int j = 0; j < k; j++)
                {
                    if (i % 2 == 1)
                    {
                        output += "+";
                    }
                    else
                    {
                        output += "*";
                    }
                }
                Console.Write("\n"+output);
            }
            Console.ReadKey();
        }
    }
}
