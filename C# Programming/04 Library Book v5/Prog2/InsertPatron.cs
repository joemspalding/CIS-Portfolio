/*
 ID : D2303
 PROGRAM 2
 DUE : TODAY LOL!!!!!
 DESCRIPTION : TO SIMULATE A LIBRARY WORKING!
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class InsertPatron : Form
    {
        public InsertPatron()
        {
            InitializeComponent();
        }

        #region Validation
        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void patronID_TxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(patronID_TxtBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider_ID.SetError(patronID_TxtBox, "Must not be blank");
                patronID_TxtBox.SelectAll();
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void patronID_TxtBox_VisibleChanged(object sender, EventArgs e)
        {
            errorProvider_ID.SetError(patronID_TxtBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void patronName_TxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(patronName_TxtBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider_Name.SetError(patronName_TxtBox, "Must not be blank");
                patronName_TxtBox.SelectAll();
            } 
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void patronName_TxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider_Name.SetError(patronName_TxtBox, "");
        }

        #endregion

        // Precondition:  All fields are valid
        // Postcondition: sends data to main form for processing
        private void addPatron_Btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                PatronID = patronID_TxtBox.Text;
                PatronName = patronName_TxtBox.Text;
            }
        }


        // Precondition:  None
        // Postcondition: Form is closed
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Get/Set is okay because validation happens on the form
        public string PatronID
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string PatronName
        {
            get; set;
        }

    }
}
