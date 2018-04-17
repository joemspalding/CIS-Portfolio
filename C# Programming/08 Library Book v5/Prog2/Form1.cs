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
    public partial class Form1 : Form
    {
        internal Library library = new Library();
        
        public Form1()
        {
            InitializeComponent();

            // Adding sample patrons to test with
            library.AddPatron("Ima Reader", "12345");
            library.AddPatron("Jane Doe", "11223");
            library.AddPatron("John Smith", "54321");
            library.AddPatron("James T. Kirk", "98765");
            library.AddPatron("Jean-Luc Picard", "33456");

            // Adding sample library media items to test with
            library.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,"ZZ25 3G", "Andrew Wright");
            library.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AB73 ZF", "IP Thief");
            library.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7, "MM33 2D", 92.5, "Andrew L. Wright", 
                LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            library.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            library.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            library.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            library.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            library.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            library.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9A", 16, 7);
            library.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9B", 16, 8);
            library.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9C", 16, 9);
            library.AddLibraryMagazine("VB Magazine", "UofL Mags", 2017, 14, "MA21 5V", 1, 1);
        }

        // Precondition:  None
        // Postcondition: The main form is closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  None
        // Postcondition: A patron is added to the master list
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertPatron insertpatron = new InsertPatron(); //create form
            string patronID; // holds patron id
            string patronName; // holds patron name
            DialogResult result; //holds dialogresult
            result = insertpatron.ShowDialog(); //spawns form
            if (result == DialogResult.OK)
            {
                // assigns all fields to temp vars and adds a new patron to the list
                patronID = insertpatron.PatronID;
                patronName = insertpatron.PatronName;
                library.AddPatron(patronID, patronName);
            }
        }

        // Precondition:  None
        // Postcondition: Grading information is displayed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine;
            MessageBox.Show($"ID : D2303 {NL}"+ 
                            $"Program Number : 2 {NL}" +
                            $"Due : 3/9/17 {NL}");
        }

        // Precondition:  None
        // Postcondition: A library book is added to the master list
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertBook insertbook = new InsertBook(); // create form
            string title; //holds title
            string author; // holds author
            string publisher; // holds  publisher
            int copyright; // holds copyright year
            int loanPeriod; // holds loan period
            string callNumber; // holds call number
            DialogResult result; // holds dialogresult
            result = insertbook.ShowDialog(); //start form
            if (result == DialogResult.OK)
            {
                // add result of fields to the temp vars and create a new librarybook
                title = insertbook.Title;
                author = insertbook.Author;
                publisher = insertbook.Publisher;
                copyright = int.Parse(insertbook.CopyrightYear);
                loanPeriod = int.Parse(insertbook.LoanPeriod);
                callNumber = insertbook.CallNumber;
                library.AddLibraryBook(title, publisher, copyright, loanPeriod, callNumber, author);
            }

        }

        // Precondition:  None
        // Postcondition: Displays all library patrons to an output
        private void patronItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; //newline shortcut
            StringBuilder patronstring = new StringBuilder(); // as not to do a lot of concats
            patronstring.Append(library.GetPatronCount() + NL + NL); // put a count on stringbuilder

            // append all patrons
            foreach (LibraryPatron patron in library.GetPatronsList())
                patronstring.Append(patron.ToString() + NL + NL);

            resultTxtBox.Text = patronstring.ToString(); //display
        }

        // Precondition:  None
        // Postcondition: Displays all library items to an output
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; //newline shortcut
            StringBuilder itemstring = new StringBuilder(); //as not to do a lot of concatanations
            itemstring.Append(library.GetItemCount() + NL + NL); // put count on stringbuilder

            // append all items
            foreach (LibraryItem item in library.GetItemsList())
                itemstring.Append(item.ToString() + NL + NL);

            resultTxtBox.Text = itemstring.ToString(); //display
        }

        // Precondition:  None
        // Postcondition: Displays all checked out library items to an output
        private void checkedOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; //newline shortcut
            StringBuilder checkoutstring = new StringBuilder(); //as not to do a lot of concatanations
            checkoutstring.Append(library.GetCheckedOutCount() + NL + NL); // put count on the stringbuilder

            // append all checkedout items
            foreach (LibraryItem item in library.GetItemsList())
            {
                if (item.IsCheckedOut())
                {
                    checkoutstring.Append(item.ToString() + NL + NL);
                }
            }

            resultTxtBox.Text = checkoutstring.ToString(); // display
        }

        // Precondition:  
        // Postcondition: 
        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // error checking
            if (library.GetPatronCount() != 0)
            {
                CheckOut checkout = new CheckOut(library.GetPatronsList(), library.GetItemsList()); // create a form as variable for later

                // store result of dialog box
                DialogResult result;
                result = checkout.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // checkout and update lists
                    library.CheckOut(checkout.LibItem, checkout.Patron);
                    library._items = checkout.ItemList;
                    library._patrons = checkout.PatronList;
                }
            }
            else
                MessageBox.Show("There must be at least one library item!");
        }

        // Precondition:  At least one item is checkedout
        // Postcondition: sets the isCheckedOut value of a single item to false.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // for error checking later for no checkout
            var checkoutquery =
                from item in library.GetItemsList()
                where item.IsCheckedOut()
                select item;
            // error checking
            if (checkoutquery != null)
            {
                
                Return returnbox = new Return(library.GetItemsList()); // create a form as variable for later
                
                // store result of dialog box
                DialogResult result; 
                result = returnbox.ShowDialog();

                // testing if they hit ok
                if (result == DialogResult.OK)
                {
                    // return desired book and update list
                    library.ReturnToShelf(returnbox.LibItem);
                    library._items = returnbox.ItemList;

                }
            }
            else
                MessageBox.Show("No items to return!");
        }
    }
}
