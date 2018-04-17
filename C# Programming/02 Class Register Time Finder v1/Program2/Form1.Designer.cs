namespace Program2
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.hoursLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.hoursTxtBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.dateSlotLbl = new System.Windows.Forms.Label();
            this.timeSlotLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(41, 44);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(100, 23);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Last Name :";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hoursLbl
            // 
            this.hoursLbl.Location = new System.Drawing.Point(41, 87);
            this.hoursLbl.Name = "hoursLbl";
            this.hoursLbl.Size = new System.Drawing.Size(100, 23);
            this.hoursLbl.TabIndex = 1;
            this.hoursLbl.Text = "Credit Hours :";
            this.hoursLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(148, 44);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 22);
            this.nameTxtBox.TabIndex = 2;
            // 
            // hoursTxtBox
            // 
            this.hoursTxtBox.Location = new System.Drawing.Point(148, 84);
            this.hoursTxtBox.Name = "hoursTxtBox";
            this.hoursTxtBox.Size = new System.Drawing.Size(100, 22);
            this.hoursTxtBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(104, 136);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(84, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // dateSlotLbl
            // 
            this.dateSlotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSlotLbl.Location = new System.Drawing.Point(84, 162);
            this.dateSlotLbl.Name = "dateSlotLbl";
            this.dateSlotLbl.Size = new System.Drawing.Size(125, 23);
            this.dateSlotLbl.TabIndex = 5;
            this.dateSlotLbl.Text = "DATE";
            this.dateSlotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeSlotLbl
            // 
            this.timeSlotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSlotLbl.Location = new System.Drawing.Point(84, 197);
            this.timeSlotLbl.Name = "timeSlotLbl";
            this.timeSlotLbl.Size = new System.Drawing.Size(125, 23);
            this.timeSlotLbl.TabIndex = 6;
            this.timeSlotLbl.Text = "TIME";
            this.timeSlotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 240);
            this.Controls.Add(this.timeSlotLbl);
            this.Controls.Add(this.dateSlotLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.hoursTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.hoursLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label hoursLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox hoursTxtBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label dateSlotLbl;
        private System.Windows.Forms.Label timeSlotLbl;
    }
}

