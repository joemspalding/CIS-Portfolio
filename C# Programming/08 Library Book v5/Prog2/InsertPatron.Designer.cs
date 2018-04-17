namespace LibraryItems
{
    partial class InsertPatron
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
            this.patronID_Lbl = new System.Windows.Forms.Label();
            this.patronID_TxtBox = new System.Windows.Forms.TextBox();
            this.patronName_Lbl = new System.Windows.Forms.Label();
            this.patronName_TxtBox = new System.Windows.Forms.TextBox();
            this.errorProvider_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.addPatron_Btn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).BeginInit();
            this.SuspendLayout();
            // 
            // patronID_Lbl
            // 
            this.patronID_Lbl.AutoSize = true;
            this.patronID_Lbl.Location = new System.Drawing.Point(12, 43);
            this.patronID_Lbl.Name = "patronID_Lbl";
            this.patronID_Lbl.Size = new System.Drawing.Size(67, 17);
            this.patronID_Lbl.TabIndex = 0;
            this.patronID_Lbl.Text = "Patron ID";
            // 
            // patronID_TxtBox
            // 
            this.patronID_TxtBox.Location = new System.Drawing.Point(112, 43);
            this.patronID_TxtBox.Name = "patronID_TxtBox";
            this.patronID_TxtBox.Size = new System.Drawing.Size(100, 22);
            this.patronID_TxtBox.TabIndex = 1;
            this.patronID_TxtBox.VisibleChanged += new System.EventHandler(this.patronID_TxtBox_VisibleChanged);
            this.patronID_TxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronID_TxtBox_Validating);
            // 
            // patronName_Lbl
            // 
            this.patronName_Lbl.AutoSize = true;
            this.patronName_Lbl.Location = new System.Drawing.Point(13, 87);
            this.patronName_Lbl.Name = "patronName_Lbl";
            this.patronName_Lbl.Size = new System.Drawing.Size(91, 17);
            this.patronName_Lbl.TabIndex = 2;
            this.patronName_Lbl.Text = "Patron Name";
            // 
            // patronName_TxtBox
            // 
            this.patronName_TxtBox.Location = new System.Drawing.Point(112, 87);
            this.patronName_TxtBox.Name = "patronName_TxtBox";
            this.patronName_TxtBox.Size = new System.Drawing.Size(100, 22);
            this.patronName_TxtBox.TabIndex = 3;
            this.patronName_TxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronName_TxtBox_Validating);
            this.patronName_TxtBox.Validated += new System.EventHandler(this.patronName_TxtBox_Validated);
            // 
            // errorProvider_ID
            // 
            this.errorProvider_ID.ContainerControl = this;
            // 
            // errorProvider_Name
            // 
            this.errorProvider_Name.ContainerControl = this;
            // 
            // addPatron_Btn
            // 
            this.addPatron_Btn.Location = new System.Drawing.Point(29, 133);
            this.addPatron_Btn.Name = "addPatron_Btn";
            this.addPatron_Btn.Size = new System.Drawing.Size(75, 29);
            this.addPatron_Btn.TabIndex = 4;
            this.addPatron_Btn.Text = "Add Patron";
            this.addPatron_Btn.UseVisualStyleBackColor = true;
            this.addPatron_Btn.Click += new System.EventHandler(this.addPatron_Btn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(122, 133);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 29);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // InsertPatron
            // 
            this.AcceptButton = this.addPatron_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 195);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addPatron_Btn);
            this.Controls.Add(this.patronName_TxtBox);
            this.Controls.Add(this.patronName_Lbl);
            this.Controls.Add(this.patronID_TxtBox);
            this.Controls.Add(this.patronID_Lbl);
            this.Name = "InsertPatron";
            this.Text = "InsertPatron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronID_Lbl;
        private System.Windows.Forms.TextBox patronID_TxtBox;
        private System.Windows.Forms.Label patronName_Lbl;
        private System.Windows.Forms.TextBox patronName_TxtBox;
        private System.Windows.Forms.ErrorProvider errorProvider_ID;
        private System.Windows.Forms.ErrorProvider errorProvider_Name;
        private System.Windows.Forms.Button addPatron_Btn;
        private System.Windows.Forms.Button cancelBtn;
    }
}