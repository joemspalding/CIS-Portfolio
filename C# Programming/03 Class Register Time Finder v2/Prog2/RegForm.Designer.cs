namespace Prog2
{
    partial class RegForm
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
            this.creditHrTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.creditHrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditHrTxt
            // 
            this.creditHrTxt.Location = new System.Drawing.Point(229, 16);
            this.creditHrTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditHrTxt.Name = "creditHrTxt";
            this.creditHrTxt.Size = new System.Drawing.Size(132, 22);
            this.creditHrTxt.TabIndex = 0;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(229, 49);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(132, 22);
            this.lastNameTxt.TabIndex = 1;
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(123, 107);
            this.findRegTimeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(132, 28);
            this.findRegTimeBtn.TabIndex = 2;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // creditHrLbl
            // 
            this.creditHrLbl.AutoSize = true;
            this.creditHrLbl.Location = new System.Drawing.Point(39, 20);
            this.creditHrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditHrLbl.Name = "creditHrLbl";
            this.creditHrLbl.Size = new System.Drawing.Size(167, 17);
            this.creditHrLbl.TabIndex = 3;
            this.creditHrLbl.Text = "Credits prior to Fall 2016:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(143, 53);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(78, 17);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Last name:";
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(87, 167);
            this.RegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(210, 17);
            this.RegLbl.TabIndex = 5;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.Location = new System.Drawing.Point(91, 188);
            this.dateTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(0, 17);
            this.dateTimeLbl.TabIndex = 6;
            // 
            // RegForm
            // 
            this.AcceptButton = this.findRegTimeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 256);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.creditHrLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.creditHrTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegForm";
            this.Text = "Program 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditHrTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.Label creditHrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label dateTimeLbl;
    }
}

