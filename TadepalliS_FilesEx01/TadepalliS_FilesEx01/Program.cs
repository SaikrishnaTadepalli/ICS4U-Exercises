using System;
using System.IO;

namespace TadepalliS_FilesEx01
{
    class Program
    {


        static void Main(string[] args)
        {
            StreamWriter fil;

            Console.Title = "Register Students";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter Number of Students to Register: ");

            int input = int.Parse(Console.ReadLine());
            string name;
            int studentNumber;

            Console.WriteLine();

            fil = File.CreateText("register.txt");

            for (int i = 1; i <= input; i++)
            {
                Console.Write("Enter name of Student {0}: ", i);
                name = Console.ReadLine();
                Console.Write("Enter student number: ");
                studentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                fil.WriteLine("Student Number {0}: {1}",i,name);
                fil.WriteLine("Student Number: {0}\n", studentNumber);
            }

            fil.Close();

            Console.WriteLine("\nData written to file register.txt");

            Console.ReadKey();
        }
    }
}
