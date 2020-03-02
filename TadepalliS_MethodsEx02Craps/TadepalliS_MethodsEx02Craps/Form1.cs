/************************************************************
    PROGRAMME	:	Methods Ex02 Craps

    OUTLINE		:	THis program rolls 2 dice, and if the sum 
                    of the dice is 7 or 11 on the first throw
                    the player wins. If the sum is 2, 3 or 12 
                    on the first throw then the player looses.
                    If the sum is 4, 5, 6, 7, 8, 9 or 10 on the 
                    first throw, the player keeps rolling until
                    the same sum is achieved. 

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	October 24, 2019
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

namespace TadepalliS_MethodsEx02Craps
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCraps_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            int point = 0;
            int rollSum = 0;

            roll(ref rollSum);

            if (rollSum == 7 || rollSum == 11)
                print("Win");
            else if (rollSum == 2 || rollSum == 3 || rollSum == 12)
                print("Lose");
            else
            {
                point = rollSum;
                lstOut.Items.Add("");
                lstOut.Items.Add("Point = " + point);
                lstOut.Items.Add("");
                do
                {
                    roll(ref rollSum);

                    if (rollSum == 7)
                        break;

                } while ((point != rollSum));

                if (rollSum == 7)
                    print("Lose");
                else
                    print("Win");

            }
        }
        private void print(string message)
        {
            lstOut.Items.Add("");
            lstOut.Items.Add("You " + message + "!");
        }
        private void roll(ref int sum)
        {
            int[] rolls = { rand.Next(1, 7), rand.Next(1, 7)};
            sum = rolls[0] + rolls[1];
            lstOut.Items.Add("Player Rolled " + rolls[0]+ " and " + rolls[1] + " = " + sum);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
