namespace LibraryItems
{
    partial class EditBook
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
            this.lbBook = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBook
            // 
            this.lbBook.FormattingEnabled = true;
            this.lbBook.ItemHeight = 16;
            this.lbBook.Location = new System.Drawing.Point(281, 14);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(229, 228);
            this.lbBook.TabIndex = 17;
            this.lbBook.SelectedIndexChanged += new System.EventHandler(this.lbBook_SelectedIndexChanged);
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 267);
            this.Controls.Add(this.lbBook);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.Controls.SetChildIndex(this.itemTitleLbl, 0);
            this.Controls.SetChildIndex(this.itemTitleTxt, 0);
            this.Controls.SetChildIndex(this.itemPublisherLbl, 0);
            this.Controls.SetChildIndex(this.itemPublisherTxt, 0);
            this.Controls.SetChildIndex(this.itemCopyrightLbl, 0);
            this.Controls.SetChildIndex(this.itemCopyrightTxt, 0);
            this.Controls.SetChildIndex(this.itemLoanPeriodLbl, 0);
            this.Controls.SetChildIndex(this.itemLoanPeriodTxt, 0);
            this.Controls.SetChildIndex(this.itemCallNumberLbl, 0);
            this.Controls.SetChildIndex(this.itemCallNumberTxt, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.Controls.SetChildIndex(this.bookAuthorLbl, 0);
            this.Controls.SetChildIndex(this.bookAuthorTxt, 0);
            this.Controls.SetChildIndex(this.lbBook, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBook;
    }
}