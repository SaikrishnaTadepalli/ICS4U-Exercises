namespace TadepalliS_ClassesEx02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceOut = new System.Windows.Forms.Label();
            this.grpDeposit = new System.Windows.Forms.GroupBox();
            this.grpWithdrawal = new System.Windows.Forms.GroupBox();
            this.txtWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.lblWithdrawalAmmount = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDeposit.SuspendLayout();
            this.grpWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepositAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(6, 29);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(150, 40);
            this.lblDepositAmount.TabIndex = 0;
            this.lblDepositAmount.Text = "Amount:";
            this.lblDepositAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmount.Location = new System.Drawing.Point(162, 29);
            this.txtDepositAmount.Multiline = true;
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(175, 40);
            this.txtDepositAmount.TabIndex = 0;
            this.txtDepositAmount.TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(12, 34);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(150, 50);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance:";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalanceOut
            // 
            this.lblBalanceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalanceOut.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceOut.Location = new System.Drawing.Point(175, 34);
            this.lblBalanceOut.Name = "lblBalanceOut";
            this.lblBalanceOut.Size = new System.Drawing.Size(225, 50);
            this.lblBalanceOut.TabIndex = 5;
            this.lblBalanceOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDeposit
            // 
            this.grpDeposit.Controls.Add(this.txtDepositAmount);
            this.grpDeposit.Controls.Add(this.lblDepositAmount);
            this.grpDeposit.Location = new System.Drawing.Point(12, 107);
            this.grpDeposit.Name = "grpDeposit";
            this.grpDeposit.Size = new System.Drawing.Size(350, 85);
            this.grpDeposit.TabIndex = 6;
            this.grpDeposit.TabStop = false;
            this.grpDeposit.Text = "Make a Deposit";
            // 
            // grpWithdrawal
            // 
            this.grpWithdrawal.Controls.Add(this.txtWithdrawalAmount);
            this.grpWithdrawal.Controls.Add(this.lblWithdrawalAmmount);
            this.grpWithdrawal.Location = new System.Drawing.Point(368, 107);
            this.grpWithdrawal.Name = "grpWithdrawal";
            this.grpWithdrawal.Size = new System.Drawing.Size(350, 85);
            this.grpWithdrawal.TabIndex = 7;
            this.grpWithdrawal.TabStop = false;
            this.grpWithdrawal.Text = "Make a Withdrawal";
            // 
            // txtWithdrawalAmount
            // 
            this.txtWithdrawalAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawalAmount.Location = new System.Drawing.Point(162, 29);
            this.txtWithdrawalAmount.Multiline = true;
            this.txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            this.txtWithdrawalAmount.Size = new System.Drawing.Size(175, 40);
            this.txtWithdrawalAmount.TabIndex = 1;
            this.txtWithdrawalAmount.TextChanged += new System.EventHandler(this.txtWithdrawalAmount_TextChanged);
            // 
            // lblWithdrawalAmmount
            // 
            this.lblWithdrawalAmmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWithdrawalAmmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawalAmmount.Location = new System.Drawing.Point(6, 29);
            this.lblWithdrawalAmmount.Name = "lblWithdrawalAmmount";
            this.lblWithdrawalAmmount.Size = new System.Drawing.Size(150, 40);
            this.lblWithdrawalAmmount.TabIndex = 0;
            this.lblWithdrawalAmmount.Text = "Amount:";
            this.lblWithdrawalAmmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(12, 201);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(350, 75);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.TabStop = false;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawal.Location = new System.Drawing.Point(368, 201);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(350, 75);
            this.btnWithdrawal.TabIndex = 9;
            this.btnWithdrawal.TabStop = false;
            this.btnWithdrawal.Text = "Withdraw";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(706, 75);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(733, 378);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.grpWithdrawal);
            this.Controls.Add(this.grpDeposit);
            this.Controls.Add(this.lblBalanceOut);
            this.Controls.Add(this.lblBalance);
            this.Name = "Form1";
            this.Text = "Account Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDeposit.ResumeLayout(false);
            this.grpDeposit.PerformLayout();
            this.grpWithdrawal.ResumeLayout(false);
            this.grpWithdrawal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceOut;
        private System.Windows.Forms.GroupBox grpDeposit;
        private System.Windows.Forms.GroupBox grpWithdrawal;
        private System.Windows.Forms.TextBox txtWithdrawalAmount;
        private System.Windows.Forms.Label lblWithdrawalAmmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnExit;
    }
}

