namespace LibraryItems
{
    partial class EditPatron
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
            this.lbPatron = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPatron
            // 
            this.lbPatron.FormattingEnabled = true;
            this.lbPatron.ItemHeight = 16;
            this.lbPatron.Location = new System.Drawing.Point(266, 18);
            this.lbPatron.Name = "lbPatron";
            this.lbPatron.Size = new System.Drawing.Size(177, 100);
            this.lbPatron.TabIndex = 15;
            this.lbPatron.SelectedIndexChanged += new System.EventHandler(this.lbPatron_SelectedIndexChanged);
            // 
            // EditPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 138);
            this.Controls.Add(this.lbPatron);
            this.Name = "EditPatron";
            this.Text = "EditPatron";
            this.Controls.SetChildIndex(this.lbPatron, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPatron;
    }
}