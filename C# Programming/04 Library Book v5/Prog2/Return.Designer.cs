namespace LibraryItems
{
    partial class Return
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
            this.itemLbl = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.returnErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(13, 41);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(65, 17);
            this.itemLbl.TabIndex = 0;
            this.itemLbl.Text = "Item Title";
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(111, 41);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(180, 24);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemComboBox_Validating);
            this.itemComboBox.Validated += new System.EventHandler(this.itemComboBox_Validated);
            // 
            // returnErrorProvider
            // 
            this.returnErrorProvider.ContainerControl = this;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(165, 113);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 34);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(37, 113);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 34);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 190);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.itemLbl);
            this.Name = "Return";
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.returnErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ErrorProvider returnErrorProvider;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}