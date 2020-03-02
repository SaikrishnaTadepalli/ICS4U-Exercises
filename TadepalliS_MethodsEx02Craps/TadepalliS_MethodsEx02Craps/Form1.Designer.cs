namespace TadepalliS_MethodsEx02Craps
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
            this.btnCraps = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCraps
            // 
            this.btnCraps.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCraps.Location = new System.Drawing.Point(12, 12);
            this.btnCraps.Name = "btnCraps";
            this.btnCraps.Size = new System.Drawing.Size(600, 60);
            this.btnCraps.TabIndex = 0;
            this.btnCraps.Text = "Craps";
            this.btnCraps.UseVisualStyleBackColor = true;
            this.btnCraps.Click += new System.EventHandler(this.btnCraps_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(600, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 25;
            this.lstOut.Location = new System.Drawing.Point(12, 78);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(600, 279);
            this.lstOut.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(624, 437);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCraps);
            this.Name = "Form1";
            this.Text = "Game Of Craps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCraps;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOut;
    }
}

