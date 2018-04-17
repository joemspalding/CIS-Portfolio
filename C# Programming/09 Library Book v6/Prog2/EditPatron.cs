/*
 GRADING ID : D2302
 Program 3
 Purpse : To edit patrons in the library
 
 Pun : Holy crapoli im so tired i want to die lol 
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditPatron : PatronForm
    {
        List<LibraryPatron> _patron = new List<LibraryPatron>();

        public EditPatron(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            //Adding patrons to our list to work with on the form
            foreach (LibraryPatron p in patronList)
            {
                    _patron.Add(p);
                    lbPatron.Items.Add(p.PatronName);
            }

            lbPatron.SelectedIndex = 0; //Filling out all the text boxes
        }

        private void lbPatron_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Setting all the textboxes to satisfy validation on the form
            int i = lbPatron.SelectedIndex;
            patronNameTxt.Text = _patron[i].PatronName;
            patronIdTxt.Text = _patron[i].PatronID;
        }

        internal int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected list box has been returned
            get
            {
                return lbPatron.SelectedIndex;
            }
        }

    }
}
