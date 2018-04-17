/*
 GRADING ID : D2302
 Program 3
 Purpse : To edit books in the library
 
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
    //Use bookform as base to make building a bit easier
    public partial class EditBook : BookForm
    {
        private List<LibraryBook> _books = new List<LibraryBook>(); //backing field to make working here a bit easier.

        public EditBook(List<LibraryItem> bookList)
        {
            InitializeComponent();

            //Making everything in a booklist so that its all a bit easier to deal with.
            foreach (LibraryItem b in bookList)
            {
                if (b is LibraryBook)
                {
                    LibraryBook lbTemp = b as LibraryBook;
                    _books.Add(lbTemp);
                    lbBook.Items.Add(lbTemp.Title);
                }
            }

            lbBook.SelectedIndex = 0;
        }

        private void lbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Focus autoset to list box
            int i = lbBook.SelectedIndex;

            //Filling out the text boxes with stuff from the list
            itemTitleTxt.Text = _books[i].Title;
            itemPublisherTxt.Text = _books[i].Publisher;
            itemCopyrightTxt.Text = _books[i].CopyrightYear.ToString();
            itemLoanPeriodTxt.Text = _books[i].LoanPeriod.ToString();
            itemCallNumberTxt.Text = _books[i].CallNumber;
            bookAuthorTxt.Text = _books[i].Author;
        }

        internal int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected list box has been returned
            get
            {
                return lbBook.SelectedIndex;
            }
        }

    }
}
