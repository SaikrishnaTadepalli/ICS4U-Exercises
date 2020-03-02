/************************************************************
    PROGRAMME	:	Classes Ex02 Accounts

    OUTLINE		:	This program creats an object of class 
                    Account and allows the user to deposit
                    and withdraw any numerical amount (can
                    withdraw only as much as is in thier 
                    account). If the user enters any invalid
                    inputs, they are notified via an appropriate
                    messagebox statement.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	Monday December 16th 2019
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

namespace TadepalliS_ClassesEx02
{
    public partial class Form1 : Form
    {

        private Account accnt;
        private decimal inputVal;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            accnt = new Account(Convert.ToDecimal(1000.00));
            lblBalanceOut.Text = (accnt.ShowBalance.ToString("C2"));
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (CheckInput(txtDepositAmount.Text))
                accnt.Deposit(inputVal);

            lblBalanceOut.Text = (accnt.ShowBalance.ToString("C2"));
            txtDepositAmount.Text = string.Empty;
            txtWithdrawalAmount.Text = string.Empty;
            txtDepositAmount.Focus();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (CheckInput(txtWithdrawalAmount.Text))
                if (inputVal > accnt.ShowBalance)
                    MessageBox.Show("Withdraw Amount too Large! Not Enough Balance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    accnt.Withdraw(inputVal);                                

            if (accnt.ShowBalance < 0)
                btnWithdrawal.Enabled = false;

            lblBalanceOut.Text = (accnt.ShowBalance.ToString("C2"));
            txtDepositAmount.Text = string.Empty;
            txtWithdrawalAmount.Text = string.Empty;
            txtWithdrawalAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckInput(string input)
        {
            if (decimal.TryParse(input, out inputVal) && inputVal > 0)
                return true;
            else            
                MessageBox.Show("Invalid Amount", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnDeposit;
        }

        private void txtWithdrawalAmount_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnWithdrawal;
        }
    }
}
