/************************************************************
    PROGRAMME	:	Classes Ex01 Roll Dice

    OUTLINE		:	This class organises data for the dice. It  
                    contains a method that rolls the dice, returns
                    the value of the face and the path of the 
                    corresponding image.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	Monday December 09 2019
************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadepalliS_ClassesEx01
{
    class Dice
    {
        private int faceVal;

        public Dice()
        {
            faceVal = 1;
        }

        public void Roll()
        {
            Random rand = new Random();
            faceVal = rand.Next(1, 7);
        }

        public static int FaceValue(Dice dice)
        {
            return dice.faceVal;
        }

        public override string ToString()
        {
            return ("Dice" + faceVal + ".png");
        }
    }
}
