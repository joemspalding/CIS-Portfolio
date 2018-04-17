namespace Program4
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.copyrightLbl = new System.Windows.Forms.Label();
            this.callNoLbl = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.publisherTxtBox = new System.Windows.Forms.TextBox();
            this.copyrightTxtBox = new System.Windows.Forms.TextBox();
            this.callNoTxtBox = new System.Windows.Forms.TextBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.detailBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.mysteryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(79, 33);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(35, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(64, 69);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(50, 17);
            this.authorLbl.TabIndex = 1;
            this.authorLbl.Text = "Author";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(47, 101);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(67, 17);
            this.publisherLbl.TabIndex = 2;
            this.publisherLbl.Text = "Publisher";
            // 
            // copyrightLbl
            // 
            this.copyrightLbl.AutoSize = true;
            this.copyrightLbl.Location = new System.Drawing.Point(12, 134);
            this.copyrightLbl.Name = "copyrightLbl";
            this.copyrightLbl.Size = new System.Drawing.Size(102, 17);
            this.copyrightLbl.TabIndex = 3;
            this.copyrightLbl.Text = "Copyright Year";
            // 
            // callNoLbl
            // 
            this.callNoLbl.AutoSize = true;
            this.callNoLbl.Location = new System.Drawing.Point(29, 167);
            this.callNoLbl.Name = "callNoLbl";
            this.callNoLbl.Size = new System.Drawing.Size(85, 17);
            this.callNoLbl.TabIndex = 4;
            this.callNoLbl.Text = "Call Number";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(120, 30);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(100, 22);
            this.titleTxtBox.TabIndex = 5;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(120, 66);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(100, 22);
            this.authorTxtBox.TabIndex = 6;
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Location = new System.Drawing.Point(119, 98);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(100, 22);
            this.publisherTxtBox.TabIndex = 7;
            // 
            // copyrightTxtBox
            // 
            this.copyrightTxtBox.Location = new System.Drawing.Point(119, 131);
            this.copyrightTxtBox.Name = "copyrightTxtBox";
            this.copyrightTxtBox.Size = new System.Drawing.Size(100, 22);
            this.copyrightTxtBox.TabIndex = 8;
            // 
            // callNoTxtBox
            // 
            this.callNoTxtBox.Location = new System.Drawing.Point(120, 164);
            this.callNoTxtBox.Name = "callNoTxtBox";
            this.callNoTxtBox.Size = new System.Drawing.Size(100, 22);
            this.callNoTxtBox.TabIndex = 9;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(82, 210);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(128, 31);
            this.addBookBtn.TabIndex = 10;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 16;
            this.bookListBox.Location = new System.Drawing.Point(243, 13);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(184, 228);
            this.bookListBox.TabIndex = 11;
            // 
            // detailBtn
            // 
            this.detailBtn.Location = new System.Drawing.Point(451, 33);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(117, 34);
            this.detailBtn.TabIndex = 12;
            this.detailBtn.Text = "Details";
            this.detailBtn.UseVisualStyleBackColor = true;
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(451, 84);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(117, 34);
            this.checkOutBtn.TabIndex = 13;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(451, 134);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(117, 34);
            this.returnBtn.TabIndex = 14;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // mysteryBtn
            // 
            this.mysteryBtn.Location = new System.Drawing.Point(451, 187);
            this.mysteryBtn.Name = "mysteryBtn";
            this.mysteryBtn.Size = new System.Drawing.Size(117, 54);
            this.mysteryBtn.TabIndex = 15;
            this.mysteryBtn.Text = "Click Me for a Good Time!";
            this.mysteryBtn.UseVisualStyleBackColor = true;
            this.mysteryBtn.Click += new System.EventHandler(this.mysteryBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.addBookBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.mysteryBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.detailBtn);
            this.Controls.Add(this.bookListBox);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.callNoTxtBox);
            this.Controls.Add(this.copyrightTxtBox);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.callNoLbl);
            this.Controls.Add(this.copyrightLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "Program4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label copyrightLbl;
        private System.Windows.Forms.Label callNoLbl;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.TextBox publisherTxtBox;
        private System.Windows.Forms.TextBox copyrightTxtBox;
        private System.Windows.Forms.TextBox callNoTxtBox;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.Button detailBtn;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button mysteryBtn;
    }
}

