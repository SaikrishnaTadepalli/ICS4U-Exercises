/************************************************************
    PROGRAMME	:	Classes Ex01 Roll Dice

    OUTLINE		:	This program creates two dice objects of
                    the dice class and rolls their faces, and
                    displays the roll value, chorresponsing image
                    and sum of both the rolls. 

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	Monday December 09 2019
************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TadepalliS_ClassesEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            Dice[] diceSet = {dice1, dice2};
            PictureBox[] picSet = { picDiceOne, picDiceTwo };

            lstOut.Items.Clear();

            for (int i = 0; i < diceSet.Length; i++)
            {
                diceSet[i].Roll();
                picSet[i].Image = Image.FromFile(diceSet[i].ToString());
                lstOut.Items.Add("Dice " + (i + 1) + ": " + Dice.FaceValue(diceSet[i]));
            }

            lstOut.Items.Add("");
            lstOut.Items.Add("Sum of Dice: " + (Dice.FaceValue(dice1) + Dice.FaceValue(dice2)));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
