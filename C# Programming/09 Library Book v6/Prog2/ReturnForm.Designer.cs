namespace LibraryItems
{
    partial class ReturnForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.itemCbo = new System.Windows.Forms.ComboBox();
            this.itemLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(195, 156);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(85, 156);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(100, 28);
            this.okBtn.TabIndex = 19;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // itemCbo
            // 
            this.itemCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCbo.FormattingEnabled = true;
            this.itemCbo.Location = new System.Drawing.Point(20, 31);
            this.itemCbo.Margin = new System.Windows.Forms.Padding(4);
            this.itemCbo.Name = "itemCbo";
            this.itemCbo.Size = new System.Drawing.Size(305, 24);
            this.itemCbo.TabIndex = 18;
            this.itemCbo.Validating += new System.ComponentModel.CancelEventHandler(this.itemCbo_Validating);
            this.itemCbo.Validated += new System.EventHandler(this.itemCbo_Validated);
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(16, 11);
            this.itemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(81, 17);
            this.itemLbl.TabIndex = 17;
            this.itemLbl.Text = "Select Item:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 199);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.itemCbo);
            this.Controls.Add(this.itemLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
        protected internal System.Windows.Forms.ComboBox itemCbo;
    }
}