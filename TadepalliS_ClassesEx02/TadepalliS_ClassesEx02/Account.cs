/************************************************************
    PROGRAMME	:	Classes Ex02 Accounts

    OUTLINE		:	This class organises data for the account.
                    It allows for an amount to be entered upon
                    initialization, an amount to be deposited
                    or withdrawn from the balance, and a way
                    to display the balance such that its read
                    only (balance cannot be changed outside of 
                    class).

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	Monday December 16th 2019
************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadepalliS_ClassesEx02
{
    class Account
    {
        private decimal balance;
        public Account(decimal startBalance)
        {
            balance = startBalance;
        }

        public decimal ShowBalance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
    }
}
