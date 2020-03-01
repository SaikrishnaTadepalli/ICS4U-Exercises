namespace TadepalliS_ClassesEx01
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
            this.lblDiceOne = new System.Windows.Forms.Label();
            this.picDiceOne = new System.Windows.Forms.PictureBox();
            this.picDiceTwo = new System.Windows.Forms.PictureBox();
            this.lblDiceTwo = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiceOne
            // 
            this.lblDiceOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiceOne.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiceOne.Location = new System.Drawing.Point(40, 20);
            this.lblDiceOne.Name = "lblDiceOne";
            this.lblDiceOne.Size = new System.Drawing.Size(100, 50);
            this.lblDiceOne.TabIndex = 0;
            this.lblDiceOne.Text = "Dice 1";
            this.lblDiceOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDiceOne
            // 
            this.picDiceOne.Location = new System.Drawing.Point(40, 80);
            this.picDiceOne.Name = "picDiceOne";
            this.picDiceOne.Size = new System.Drawing.Size(100, 100);
            this.picDiceOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceOne.TabIndex = 1;
            this.picDiceOne.TabStop = false;
            // 
            // picDiceTwo
            // 
            this.picDiceTwo.Location = new System.Drawing.Point(190, 80);
            this.picDiceTwo.Name = "picDiceTwo";
            this.picDiceTwo.Size = new System.Drawing.Size(100, 100);
            this.picDiceTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceTwo.TabIndex = 3;
            this.picDiceTwo.TabStop = false;
            // 
            // lblDiceTwo
            // 
            this.lblDiceTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiceTwo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiceTwo.Location = new System.Drawing.Point(190, 20);
            this.lblDiceTwo.Name = "lblDiceTwo";
            this.lblDiceTwo.Size = new System.Drawing.Size(100, 50);
            this.lblDiceTwo.TabIndex = 2;
            this.lblDiceTwo.Text = "Dice 2";
            this.lblDiceTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(340, 80);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(140, 45);
            this.btnRollDice.TabIndex = 4;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(340, 135);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 25;
            this.lstOut.Location = new System.Drawing.Point(40, 205);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(440, 104);
            this.lstOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRollDice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(523, 333);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.picDiceTwo);
            this.Controls.Add(this.lblDiceTwo);
            this.Controls.Add(this.picDiceOne);
            this.Controls.Add(this.lblDiceOne);
            this.Name = "Form1";
            this.Text = "Rolling Dice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDiceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDiceOne;
        private System.Windows.Forms.PictureBox picDiceOne;
        private System.Windows.Forms.PictureBox picDiceTwo;
        private System.Windows.Forms.Label lblDiceTwo;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOut;
    }
}

