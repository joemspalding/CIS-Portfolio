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
    public partial class CheckOut : Form
    {

        public CheckOut(List<LibraryPatron> patronList, List<LibraryItem> itemList)
        {
            InitializeComponent();
            PatronList = patronList;
            ItemList = itemList;

            foreach (LibraryItem item in ItemList)
            {
                if (!item.IsCheckedOut())
                    libItemComboBox.Items.Add(item.Title + "," + item.CallNumber);
            }

            foreach (LibraryPatron patron in PatronList)
                patronComboBox.Items.Add(patron.PatronName + "," + patron.PatronID);

        }

        #region Validation
        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void libItemComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(libItemComboBox.SelectedIndex < 0 || 
                libItemComboBox.SelectedIndex > libItemComboBox.Items.Count)
            {
                e.Cancel = true;
                checkOutErrorProvider.SetError(libItemComboBox, "Must not be blank");
                libItemComboBox.SelectAll();
            } else
            {
                if (string.IsNullOrEmpty(libItemComboBox.Text.Trim()))
                {
                    e.Cancel = true;
                    checkOutErrorProvider.SetError(libItemComboBox, "Must not be blank");
                    libItemComboBox.SelectAll();
                }
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void libItemComboBox_Validated(object sender, EventArgs e)
        {
            checkOutErrorProvider.SetError(libItemComboBox, "");
        }

        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void patronComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (patronComboBox.SelectedIndex < 0 ||
                 patronComboBox.SelectedIndex > patronComboBox.Items.Count)
            {
                e.Cancel = true;
                checkOutErrorProvider.SetError(patronComboBox, "Must not be blank");
                patronComboBox.SelectAll();
            }
            else
            {
                if (string.IsNullOrEmpty(patronComboBox.Text.Trim()))
                {
                    e.Cancel = true;
                    checkOutErrorProvider.SetError(patronComboBox, "Must not be blank");
                    patronComboBox.SelectAll();
                }
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void patronComboBox_Validated(object sender, EventArgs e)
        {
            checkOutErrorProvider.SetError(patronComboBox, "");
        }


        #endregion

        // Precondition:  None
        // Postcondition: Form is closed
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User must have something selected in every combobox
        // Postcondition: The results are sent to the main form for processing
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;

                int commaindex = libItemComboBox.Text.IndexOf(',');

                ItemCallNumber = libItemComboBox.Text;
                ItemCallNumber = ItemCallNumber.Substring(commaindex + 1,(ItemCallNumber.Length - 1)-commaindex);

                LibItem = ItemList.FindIndex(x => x.CallNumber.Contains(ItemCallNumber));

                Patron = patronComboBox.SelectedIndex;
            }
        }

        // Get/Set is okay because validation happens on the form
        public List<LibraryItem> ItemList
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public List<LibraryPatron> PatronList
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public int LibItem
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string ItemTitle
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string ItemCallNumber
        {
            get; set; 
        }

        // Get/Set is okay because validation happens on the form
        public int Patron
        {
            get; set;
        }


    }
}
