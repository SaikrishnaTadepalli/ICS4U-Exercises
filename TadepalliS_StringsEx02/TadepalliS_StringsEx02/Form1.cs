/************************************************************
    PROGRAMME	:	Strings Ex02 Text Processing

    OUTLINE		:	This programme reads the text from the file 
                    and outputs the number of lines of text and 
                    the number of times each letter appears in 
                    the text.

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
using System.IO;
namespace TadepalliS_StringsEx02
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
            txtInput.ReadOnly = true;
        }
        private void k(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            string[] lines = File.ReadAllLines("txtIn.txt");
            txtInput.Text = File.ReadAllText("txtIn.txt");
            string[] letters = ("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z").Split(Convert.ToChar(" "));
            int[] letterCount = new int[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                    for (int k = 0; k < lines[j].Length; k++)
                        if (letters[i] == lines[j][k].ToString().ToUpper())
                            letterCount[i] += 1;
                lstOut.Items.Add(letters[i] + " count = " + letterCount[i]);
            }

            lstOut.Items.Add("No. of lines = " + lines.Length);

        }
    }
}
