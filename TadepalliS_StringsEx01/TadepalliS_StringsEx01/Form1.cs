/************************************************************
    PROGRAMME	:	Strings Ex01 Most Frequent Character

    OUTLINE		:	This programme asks the user for a string 
                    input and outputs the most frequently 
                    occurring letter in the text inputed.


    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	November 10th 2019
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

namespace TadepalliS_StringsEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
        private void btnFindIt_Click(object sender, EventArgs e)
        {
            string input = (txtInput.Text).Replace(" ", String.Empty);
            int[] repeats = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < input.Length; j++)
                    if (input[i] == input[j])
                        repeats[i] += 1;

            txtOut.Text = "The most frequent character is \'" + input[Array.IndexOf(repeats,(repeats.Max()))] + "\'.";
        }
    }
}
