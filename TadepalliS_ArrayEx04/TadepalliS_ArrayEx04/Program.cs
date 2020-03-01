/************************************************************
    PROGRAMME	:	Array Ex04

    OUTLINE		:	This program reads a file consisting of 
                    students’ test scores. It determines the 
                    number of students having scores in each 
                    of the following ranges: 0 – 24, 25 – 49, 
                    50 – 74, 75 – 99, 100 – 124, 125 – 149, 
                    150 – 174, 175 – 200 and outputs the
                    count formatted to two decimal places

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	October 7th 2019
************************************************************/

using System;
using System.IO;

namespace TadepalliS_ArrayEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array Ex04";
            Console.ForegroundColor = ConsoleColor.Cyan;

            StreamReader sr = new StreamReader("scores.txt");

            string[] scores = (sr.ReadLine()).Split(", ");
            int[] scoreRangeCount = new int[8];
            int[] rangeMin = { 0, 25, 50, 75, 100, 125, 150, 175 };

            foreach (string s in scores)
            {
                for (int i = 0; i <= rangeMin.Length - 1; i++)
                {
                    if (int.Parse(s) >= rangeMin[i] & int.Parse(s) < (rangeMin[i]+25))
                    {
                        scoreRangeCount[i] += 1;
                    }
                }
                if (int.Parse(s) == 200)
                    scoreRangeCount[scoreRangeCount.Length - 1] += 1;
            }

            for (int i = 0; i <= scoreRangeCount.Length - 1; i++)
                Console.WriteLine("\tGrade Range {0} - {1} has:\t{2} student(s)", Convert.ToString(rangeMin[i]).PadLeft(4,Convert.ToChar(" ")), 
                    Convert.ToString(rangeMin[i]+25).PadRight(4, Convert.ToChar(" ")), scoreRangeCount[i]);

            Console.ReadKey();
        }
    }
}
