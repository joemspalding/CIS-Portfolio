namespace LibraryItems
{
    partial class InsertBook
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
            this.components = new System.ComponentModel.Container();
            this.titleLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.copyrightLbl = new System.Windows.Forms.Label();
            this.loanPeriodLbl = new System.Windows.Forms.Label();
            this.callNumberLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.publisherTxtBox = new System.Windows.Forms.TextBox();
            this.copyrightTxtBox = new System.Windows.Forms.TextBox();
            this.loanPeriodTxtBox = new System.Windows.Forms.TextBox();
            this.callNumberTxtBox = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bookErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(75, 45);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(39, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title ";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(47, 111);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(67, 17);
            this.publisherLbl.TabIndex = 1;
            this.publisherLbl.Text = "Publisher";
            // 
            // copyrightLbl
            // 
            this.copyrightLbl.AutoSize = true;
            this.copyrightLbl.Location = new System.Drawing.Point(12, 148);
            this.copyrightLbl.Name = "copyrightLbl";
            this.copyrightLbl.Size = new System.Drawing.Size(102, 17);
            this.copyrightLbl.TabIndex = 2;
            this.copyrightLbl.Text = "Copyright Year";
            // 
            // loanPeriodLbl
            // 
            this.loanPeriodLbl.AutoSize = true;
            this.loanPeriodLbl.Location = new System.Drawing.Point(29, 187);
            this.loanPeriodLbl.Name = "loanPeriodLbl";
            this.loanPeriodLbl.Size = new System.Drawing.Size(85, 17);
            this.loanPeriodLbl.TabIndex = 3;
            this.loanPeriodLbl.Text = "Loan Period";
            // 
            // callNumberLbl
            // 
            this.callNumberLbl.AutoSize = true;
            this.callNumberLbl.Location = new System.Drawing.Point(29, 225);
            this.callNumberLbl.Name = "callNumberLbl";
            this.callNumberLbl.Size = new System.Drawing.Size(85, 17);
            this.callNumberLbl.TabIndex = 4;
            this.callNumberLbl.Text = "Call Number";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(64, 77);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(50, 17);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(139, 42);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(100, 22);
            this.titleTxtBox.TabIndex = 6;
            this.titleTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTxtBox_Validating);
            this.titleTxtBox.Validated += new System.EventHandler(this.titleTxtBox_Validated);
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(139, 77);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(100, 22);
            this.authorTxtBox.TabIndex = 7;
            this.authorTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.authorTxtBox_Validating);
            this.authorTxtBox.Validated += new System.EventHandler(this.authorTxtBox_Validated);
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Location = new System.Drawing.Point(139, 111);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(100, 22);
            this.publisherTxtBox.TabIndex = 8;
            this.publisherTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.publisherTxtBox_Validating);
            this.publisherTxtBox.Validated += new System.EventHandler(this.publisherTxtBox_Validated);
            // 
            // copyrightTxtBox
            // 
            this.copyrightTxtBox.Location = new System.Drawing.Point(139, 148);
            this.copyrightTxtBox.Name = "copyrightTxtBox";
            this.copyrightTxtBox.Size = new System.Drawing.Size(100, 22);
            this.copyrightTxtBox.TabIndex = 9;
            this.copyrightTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightTxtBox_Validating);
            this.copyrightTxtBox.Validated += new System.EventHandler(this.copyrightTxtBox_Validated);
            // 
            // loanPeriodTxtBox
            // 
            this.loanPeriodTxtBox.Location = new System.Drawing.Point(139, 187);
            this.loanPeriodTxtBox.Name = "loanPeriodTxtBox";
            this.loanPeriodTxtBox.Size = new System.Drawing.Size(100, 22);
            this.loanPeriodTxtBox.TabIndex = 10;
            this.loanPeriodTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeriodTxtBox_Validating);
            this.loanPeriodTxtBox.Validated += new System.EventHandler(this.loanPeriodTxtBox_Validated);
            // 
            // callNumberTxtBox
            // 
            this.callNumberTxtBox.Location = new System.Drawing.Point(139, 225);
            this.callNumberTxtBox.Name = "callNumberTxtBox";
            this.callNumberTxtBox.Size = new System.Drawing.Size(100, 22);
            this.callNumberTxtBox.TabIndex = 11;
            this.callNumberTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.callNumberTxtBox_Validating);
            this.callNumberTxtBox.Validated += new System.EventHandler(this.callNumberTxtBox_Validated);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(50, 270);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 31);
            this.acceptBtn.TabIndex = 12;
            this.acceptBtn.Text = "Add";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(149, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 31);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // bookErrorProvider
            // 
            this.bookErrorProvider.ContainerControl = this;
            // 
            // InsertBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 334);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.callNumberTxtBox);
            this.Controls.Add(this.loanPeriodTxtBox);
            this.Controls.Add(this.copyrightTxtBox);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.callNumberLbl);
            this.Controls.Add(this.loanPeriodLbl);
            this.Controls.Add(this.copyrightLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "InsertBook";
            this.Text = "InsertBook";
            ((System.ComponentModel.ISupportInitialize)(this.bookErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label copyrightLbl;
        private System.Windows.Forms.Label loanPeriodLbl;
        private System.Windows.Forms.Label callNumberLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.TextBox publisherTxtBox;
        private System.Windows.Forms.TextBox copyrightTxtBox;
        private System.Windows.Forms.TextBox loanPeriodTxtBox;
        private System.Windows.Forms.TextBox callNumberTxtBox;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider bookErrorProvider;
    }
}