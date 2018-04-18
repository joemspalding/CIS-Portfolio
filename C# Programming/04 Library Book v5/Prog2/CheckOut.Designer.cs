namespace LibraryItems
{
    partial class CheckOut
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
            this.libItemComboBox = new System.Windows.Forms.ComboBox();
            this.libItemLbl = new System.Windows.Forms.Label();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.patronLbl = new System.Windows.Forms.Label();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.checkOutErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkOutErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // libItemComboBox
            // 
            this.libItemComboBox.FormattingEnabled = true;
            this.libItemComboBox.Location = new System.Drawing.Point(119, 64);
            this.libItemComboBox.Name = "libItemComboBox";
            this.libItemComboBox.Size = new System.Drawing.Size(209, 24);
            this.libItemComboBox.TabIndex = 0;
            this.libItemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.libItemComboBox_Validating);
            this.libItemComboBox.Validated += new System.EventHandler(this.libItemComboBox_Validated);
            // 
            // libItemLbl
            // 
            this.libItemLbl.AutoSize = true;
            this.libItemLbl.Location = new System.Drawing.Point(21, 67);
            this.libItemLbl.Name = "libItemLbl";
            this.libItemLbl.Size = new System.Drawing.Size(82, 17);
            this.libItemLbl.TabIndex = 1;
            this.libItemLbl.Text = "Library Item";
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(119, 124);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(209, 24);
            this.patronComboBox.TabIndex = 2;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronComboBox_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.patronComboBox_Validated);
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(24, 130);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(50, 17);
            this.patronLbl.TabIndex = 3;
            this.patronLbl.Text = "Patron";
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(119, 197);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(93, 33);
            this.checkOutBtn.TabIndex = 4;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(242, 197);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // checkOutErrorProvider
            // 
            this.checkOutErrorProvider.ContainerControl = this;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 253);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.patronLbl);
            this.Controls.Add(this.patronComboBox);
            this.Controls.Add(this.libItemLbl);
            this.Controls.Add(this.libItemComboBox);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.checkOutErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox libItemComboBox;
        private System.Windows.Forms.Label libItemLbl;
        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider checkOutErrorProvider;
    }
}