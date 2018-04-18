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
    public partial class InsertBook : Form
    {
        const int MIN_COPYRIGHT_YEAR = 0;

        public InsertBook()
        {
            InitializeComponent();
        }

        #region Validation
        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away

        private void titleTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxtBox.Text.Trim()))
            {
                e.Cancel = true;
                bookErrorProvider.SetError(titleTxtBox, "Must not be blank!");
                titleTxtBox.SelectAll();
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void titleTxtBox_Validated(object sender, EventArgs e)
        {
            bookErrorProvider.SetError(titleTxtBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void authorTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(authorTxtBox.Text.Trim()))
            {
                e.Cancel = true;
                bookErrorProvider.SetError(authorTxtBox, "Must not be blank!");
                authorTxtBox.SelectAll();
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void authorTxtBox_Validated(object sender, EventArgs e)
        {
            bookErrorProvider.SetError(authorTxtBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void publisherTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(publisherTxtBox.Text.Trim()))
            {
                e.Cancel = true;
                bookErrorProvider.SetError(publisherTxtBox, "Must not be blank!");
                publisherTxtBox.SelectAll();
            }
        }

        private void publisherTxtBox_Validated(object sender, EventArgs e)
        {
            bookErrorProvider.SetError(publisherTxtBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void copyrightTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int _copyright;
            if (!int.TryParse(copyrightTxtBox.Text.Trim(), out _copyright))
            {
                e.Cancel = true;
                bookErrorProvider.SetError(copyrightTxtBox, "Must be an integer value!");
                copyrightTxtBox.SelectAll();
            }
            else
            {
                if (_copyright < MIN_COPYRIGHT_YEAR)
                {
                    e.Cancel = true;
                    bookErrorProvider.SetError(copyrightTxtBox, $"Must be greater than {MIN_COPYRIGHT_YEAR}!");
                    copyrightTxtBox.SelectAll();
                }
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void copyrightTxtBox_Validated(object sender, EventArgs e)
        {
            bookErrorProvider.SetError(copyrightTxtBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void loanPeriodTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int _loanPeriod;
            if (!int.TryParse(loanPeriodTxtBox.Text.Trim(), out _loanPeriod))
            {
                e.Cancel = true;
                bookErrorProvider.SetError(loanPeriodTxtBox, "Must be an integer value!");
                loanPeriodTxtBox.SelectAll();
            }
            else
            {
                if (_loanPeriod < 0)
                {
                    e.Cancel = true;
                    bookErrorProvider.SetError(loanPeriodTxtBox, "Must be greater than 0!");
                    loanPeriodTxtBox.SelectAll();
                }
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void loanPeriodTxtBox_Validated(object sender, EventArgs e)
        {
            bookErrorProvider.SetError(loanPeriodTxtBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void callNumberTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(callNumberTxtBox.Text.Trim()))
            {
                e.Cancel = true;
                bookErrorProvider.SetError(callNumberTxtBox, "Must not be blank!");
                callNumberTxtBox.SelectAll();
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void callNumberTxtBox_Validated(object sender, EventArgs e)
        {
            bookErrorProvider.SetError(callNumberTxtBox, "");
        }



        #endregion


        // Precondition:  All fields are valid
        // Postcondition: sends data to main form for processing
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                Title = titleTxtBox.Text;
                Author = authorTxtBox.Text;
                Publisher = publisherTxtBox.Text;
                CopyrightYear = copyrightTxtBox.Text;
                LoanPeriod = loanPeriodTxtBox.Text;
                CallNumber = callNumberTxtBox.Text;
            }
        }

        #region Properties
        // Get/Set is okay because validation happens on the form
        public string Title
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string Author
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string Publisher
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string CopyrightYear
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string LoanPeriod
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string CallNumber
        {
            get; set;
        }
        #endregion

        // Precondition:  None
        // Postcondition: Form is closed
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
