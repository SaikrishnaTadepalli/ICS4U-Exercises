/************************************************************
    PROGRAMME	:	IF/Switch Ex03 AREA OF CIRCLE< RECTANGLE OR CYLINDER

    OUTLINE		:	This programme asks the user to select weather
                    they want to calculate the area of a circle
                    rectangle or volume or a cylinder. They are then
                    prompted to input the proper parameters and the
                    respective data (area / volume of selected object)
                    if outputted to two decimal places

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	September 10, 2019
 ************************************************************/

using System;

namespace TadepalliS_IfEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AREA OF CIRCLE,RECTANGLE,OR CYLINDER";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string inStr;
            int input;
            string output;

            Console.Write("\tCalculate area of\n\n\t1) Circle\n\t2) Rectange\n\t3) Volume of Cylinder\n\n\tChoose one: ");

            inStr = Console.ReadLine();

            if (int.TryParse(inStr, out input))
            {
                //input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    double radius;

                    Console.Write("\n\tEnter Radius of Circle: ");
                    radius = double.Parse(Console.ReadLine());

                    output = "\n\tArea of Circle With Radius " + radius + " = " + (Circle(radius));
                }
                else if (input == 2)
                {
                    double length;
                    double width;

                    Console.Write("\n\tEnter Length of Rectangle: ");
                    length = double.Parse(Console.ReadLine());

                    Console.Write("\n\tEnter Width of Rectangle: ");
                    width = double.Parse(Console.ReadLine());

                    output = "\n\tArea of Rectangle With Length " + length + " and Width " + width + " = " + Rectangle(length, width);
                }
                else if (input == 3)
                {
                    double radius;
                    double height;

                    Console.Write("\n\tEnter Length of Cylinder: ");
                    radius = double.Parse(Console.ReadLine());

                    Console.Write("\n\tEnter Width of Cylinder: ");
                    height = double.Parse(Console.ReadLine());

                    output = "\n\tVolume of Cylinder With Radius " + radius + " and Height " + height + " = " + Cylinder(radius, height);
                }
                else
                {
                    output = "\n\tInvalid input, enter only numbers 1 to 3!";
                }

                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("\n\tInvalid input, enter only numbers 1 to 3!");
            }


            Console.ReadKey();
        }

        static string Circle(double rad)
        {
            double area = Math.PI * rad * rad;
            string output =  area.ToString("#.##");
            return output;
        }

        static string Rectangle(double len, double wid)
        {
            double area = len * wid;
            string output = area.ToString("#.##");
            return output;
        }

        static string Cylinder(double rad, double heightCyl)
        {
            double area = Math.PI * rad * rad * heightCyl;
            string output = area.ToString("#.##");
            return output;
        }
    }
}
