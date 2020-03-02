/************************************************************
    PROGRAMME	:	Methods Ex01 Number Palindrome

    OUTLINE		:	This programme asks the user for  a number
                    and returns true if the number is greater
                    than or equal to 0, and when it is read 
                    from left to right or right to left it is
                    exactly the same in both directions. 

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	October 24, 2019
 ************************************************************/

using System;

namespace TadepalliS__NumberPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            do
            {
                Console.Write("\n\tEnter a number: ");
                num = int.Parse(Console.ReadLine());

                if (IsNumPalindrome(num))
                {
                    Console.WriteLine("\n\t" + num + " is a palindrome.");
                }
                else
                {
                    Console.WriteLine("\n\t" + num + " is NOT a palindrome.");
                }

            } while (true);
        }

        static Boolean IsNumPalindrome(int input)
        {
            if (input < 0)
                return false;

            if (input >= 0 && input < 10)
                return true;

            int pwr = input.ToString().Length -1;

            do
            {
                if (input.ToString().Substring(0, 1) != input.ToString().Substring(input.ToString().Length - 1, 1))
                    return false;
                else
                {
                    input = int.Parse(input.ToString().Remove(0, 1));
                    input = int.Parse(input.ToString().Remove(input.ToString().Length - 1, 1).PadLeft(1,Convert.ToChar("0")));
                    pwr -= 2;
                }
            } while (input >= 10);

            return true;
        }
    }
}
