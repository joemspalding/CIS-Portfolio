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
    public partial class Return : Form
    {

        public Return(List<LibraryItem> itemList)
        {
            InitializeComponent();

            //to only display checked out items
            foreach (LibraryItem item in ItemList)
            {
                if (item.IsCheckedOut())
                    itemComboBox.Items.Add(item.Title + "," + item.CallNumber);
            }
        }

        #region Validation
        // Precondition:  None
        // Postcondition: User is prevented from shifting focus away
        private void itemComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (itemComboBox.SelectedIndex < 0 ||
                itemComboBox.SelectedIndex > itemComboBox.Items.Count)
            {
                e.Cancel = true;
                returnErrorProvider.SetError(itemComboBox, "Must not be blank");
                itemComboBox.SelectAll();
            }
            else
            {
                if (string.IsNullOrEmpty(itemComboBox.Text.Trim()))
                {
                    e.Cancel = true;
                    returnErrorProvider.SetError(itemComboBox, "Must not be blank");
                    itemComboBox.SelectAll();
                }
            }
        }

        // Precondition:  None
        // Postcondition: User can leave and no error message
        private void itemComboBox_Validated(object sender, EventArgs e)
        {
            returnErrorProvider.SetError(itemComboBox, "");
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
        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;

                int commaindex = itemComboBox.Text.IndexOf(',');

                ItemCallNumber = itemComboBox.Text;
                ItemCallNumber = ItemCallNumber.Substring(commaindex + 1, (ItemCallNumber.Length - 1) - commaindex);

                LibItem = ItemList.FindIndex(x => x.CallNumber.Contains(ItemCallNumber));

            }
        }

        // Get/Set is okay because validation happens on the form
        public List<LibraryItem> ItemList
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public int LibItem
        {
            get; set;
        }

        // Get/Set is okay because validation happens on the form
        public string ItemCallNumber
        {
            get; set;
        }



    }
}
