// Program 2
// CIS 200-01
// Due: 4/5/2017
// By: D2302

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.
// Also enables editing patrons/books and opening/saving those changes to a file

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LibraryItems
{
    public partial class Prog2Form : Form
    {
        private Library _lib; // The library
        private IFormatter format = new BinaryFormatter(); //Used to serialize and deserialize
        string fileName; //file path

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 2{NL}By: Andrew L. Wright{NL}CIS 200-01{NL}Spring 2017",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons;                // List of patrons
            string NL = Environment.NewLine;            // NewLine shortcut

            patrons = _lib.GetPatronsList();

            result.Append($"Patron List - {patrons.Count} patrons{NL}{NL}");

            foreach (LibraryPatron p in patrons)
                result.Append($"{p}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            result.Append($"Item List - {items.Count} items{NL}{NL}");

            foreach (LibraryItem item in items)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append($"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}");

            foreach (LibraryItem item in checkedOutItems)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that aren't already checked out

            List<LibraryItem> notCheckedOutList; // List of items not checked out
            List<int> notCheckedOutIndices;      // List of index values of items not checked out
            List<LibraryItem> items;             // List of library items
            List<LibraryPatron> patrons;         // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();
            notCheckedOutList = new List<LibraryItem>();
            notCheckedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (!items[i].IsCheckedOut()) // Not checked out
                {
                    notCheckedOutList.Add(items[i]);
                    notCheckedOutIndices.Add(i);
                }

            if ((notCheckedOutList.Count() == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(notCheckedOutList, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = notCheckedOutIndices[checkoutForm.ItemIndex]; // Look up index from full list
                        _lib.CheckOut(itemIndex, checkoutForm.PatronIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Check Out Index!", "Check Out Error");
                    }
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that are already checked out

            List<LibraryItem> checkedOutList; // List of items checked out
            List<int> checkedOutIndices;      // List of index values of items checked out
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();
            checkedOutList = new List<LibraryItem>();
            checkedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (items[i].IsCheckedOut()) // Checked out
                {
                    checkedOutList.Add(items[i]);
                    checkedOutIndices.Add(i);
                }

            if ((checkedOutList.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(checkedOutList); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = checkedOutIndices[returnForm.ItemIndex]; // Look up index from full list
                        _lib.ReturnToShelf(itemIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Return Index!", "Return Error");
                    }
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition  : _lib._patrons.Count() > 0
        // Postcondition : a single item in _lib._patrons has been updated
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons = _lib.GetPatronsList(); // Creating a temporary editable patron list.

            if (patrons.Count() == 0) // Testing if empty
                MessageBox.Show("There are no Patrons");
            else
            {
                // Setting up the EditPatron form to be displayed
                EditPatron editPatronForm = new EditPatron(patrons);
                DialogResult result = new DialogResult();

                result = editPatronForm.ShowDialog();

                if (result == DialogResult.OK) //on successful submission
                {
                    try
                    {
                        // aliasing for easier referencing and readability
                        int index = editPatronForm.ItemIndex;
                        LibraryPatron editpatron = _lib._patrons[index];

                        //updating the master list
                        editpatron.PatronName = editPatronForm.patronNameTxt.Text;
                        editpatron.PatronID = editPatronForm.patronIdTxt.Text;
                    }
                    catch (FormatException) //shouldnt show up if form did validation correctly
                    {
                        MessageBox.Show("Problem with Patron Validation!", "Validation Error");
                    }
                }

                editPatronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition  : There is at least 1 LibraryBook in _items
        // Postcondition : Edits a single libraryitem if it is a LibraryBook
        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryItem> isBookList = new List<LibraryItem>(); //List of Books
            List<int> bookIndex = new List<int>(); // Index table to cross reference on filtered list to master list
            List<LibraryItem> items = _lib.GetItemsList(); // List of all items

            // Creating a sublist for LibraryItems that are also LibraryBooks
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i] is LibraryBook)
                {
                    isBookList.Add(items[i]);
                    bookIndex.Add(i);
                }
            }

            if (isBookList.Count() == 0) // if there are no library books
                MessageBox.Show("There are no Books.");
            else
            {
                // setting up the EditBook form to be displayed
                EditBook editBookForm = new EditBook(isBookList);
                DialogResult result = editBookForm.ShowDialog();

                if (result == DialogResult.OK) // on successful form submission
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items
                        itemIndex = bookIndex[editBookForm.ItemIndex]; // Look up index from full list
                        LibraryBook editbook = (LibraryBook)_lib._items[itemIndex];

                        // updating the master list
                        editbook.Title = editBookForm.ItemTitle;
                        editbook.Publisher = editBookForm.ItemPublisher;
                        editbook.CopyrightYear = int.Parse(editBookForm.ItemCopyrightYear);
                        editbook.LoanPeriod = int.Parse(editBookForm.ItemLoanPeriod);
                        editbook.CallNumber = editBookForm.ItemCallNumber;
                        editbook.Author = editBookForm.BookAuthor;
                    }
                    catch (FormatException) // This should never happen if form validation works!
                    {
                        MessageBox.Show("Problem with Book Validation!", "Validation Error");
                    }
                }
                editBookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }

        }

        //Precondition : There is a file with serialized library data
        //Postcondition: Opens the file and allows the user to edit it.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile(); //Opens the file
        }

        //Precondition  : Library is serializable
        //Postcondition : Library is saved
        private void SaveFile()
        {
            DialogResult result; //Used to store the result of (un)successful saves
            FileStream output = null; //Used to write to files

            //Open Save DialogBox
            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            //If the SaveDialog closes successfully
            if (result == DialogResult.OK)
            {
                //Testing to see if theres a vaild filepath
                if (string.IsNullOrEmpty(fileName))
                    MessageBox.Show("Invalid file path");
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.Create, FileAccess.Write); //Creating a stream
                        format.Serialize(output, _lib); //Serializing
                    }
                    // catch exceptions
                    catch (IOException)
                    {
                        MessageBox.Show("Error saving file");
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Unable to Serialize");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid Format");
                    }
                    try
                    {
                        output?.Close(); //Close file
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Cannot close file");
                    }
                }
            }
            //Actual saving
            try
            {
                Stream stream = new FileStream(@"\Prog3Library.dat", FileMode.Create, FileAccess.Write);
                format.Serialize(stream, _lib); //Saving
                stream.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorized Permissions"); //This was a personal weird error.
            }
        }

        //Precondition  : A library binary serialized file exists
        //Postcondition : Opens the file
        private void OpenFile()
        {
            FileStream input; //Used to read files
            DialogResult result; //Used to open the open file dialog

            //Open open file dialog box
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            
            //Testing to see if dialog closed successfully
            if(result == DialogResult.OK)
            {
                input = new FileStream(fileName, FileMode.Open, FileAccess.Read); //Giving the filestream a read purpose
                try
                {
                    _lib = (Library)format.Deserialize(input); //try to deserialize it into a library object
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Unable to De-serialize"); //on fail, give a simple error message
                }
                finally
                {
                    input?.Close(); //always close dat stuff
                }
            }
        }

        //On close
        private void Prog2Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Attempt to catch unsaved data
            DialogResult result = MessageBox.Show("Save Without Closing? \nOK to save. Cancel to continue exiting.", "Alert!", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                SaveFile();
            }
        }

        //Precondition  : Library is serializable
        //Postcondition : Library is saved
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}

