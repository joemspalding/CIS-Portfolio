namespace LibraryItems
{
    partial class PatronForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.patronNameLbl = new System.Windows.Forms.Label();
            this.patronNameTxt = new System.Windows.Forms.TextBox();
            this.patronIdLbl = new System.Windows.Forms.Label();
            this.patronIdTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // patronNameLbl
            // 
            this.patronNameLbl.AutoSize = true;
            this.patronNameLbl.Location = new System.Drawing.Point(16, 18);
            this.patronNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronNameLbl.Name = "patronNameLbl";
            this.patronNameLbl.Size = new System.Drawing.Size(49, 17);
            this.patronNameLbl.TabIndex = 0;
            this.patronNameLbl.Text = "Name:";
            // 
            // patronNameTxt
            // 
            this.patronNameTxt.Location = new System.Drawing.Point(92, 15);
            this.patronNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patronNameTxt.Name = "patronNameTxt";
            this.patronNameTxt.Size = new System.Drawing.Size(132, 22);
            this.patronNameTxt.TabIndex = 1;
            this.patronNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameTxt_Validating);
            this.patronNameTxt.Validated += new System.EventHandler(this.patronNameTxt_Validated);
            // 
            // patronIdLbl
            // 
            this.patronIdLbl.AutoSize = true;
            this.patronIdLbl.Location = new System.Drawing.Point(39, 52);
            this.patronIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronIdLbl.Name = "patronIdLbl";
            this.patronIdLbl.Size = new System.Drawing.Size(25, 17);
            this.patronIdLbl.TabIndex = 2;
            this.patronIdLbl.Text = "ID:";
            // 
            // patronIdTxt
            // 
            this.patronIdTxt.Location = new System.Drawing.Point(92, 48);
            this.patronIdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patronIdTxt.Name = "patronIdTxt";
            this.patronIdTxt.Size = new System.Drawing.Size(132, 22);
            this.patronIdTxt.TabIndex = 3;
            this.patronIdTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronIdTxt_Validating);
            this.patronIdTxt.Validated += new System.EventHandler(this.patronIdTxt_Validated);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(125, 98);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(16, 98);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(100, 28);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 138);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronIdTxt);
            this.Controls.Add(this.patronIdLbl);
            this.Controls.Add(this.patronNameTxt);
            this.Controls.Add(this.patronNameLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatronForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label patronIdLbl;
        private System.Windows.Forms.Label patronNameLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        protected internal System.Windows.Forms.TextBox patronIdTxt;
        protected internal System.Windows.Forms.TextBox patronNameTxt;
    }
}