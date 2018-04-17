/*
 Remove Kebab - https://youtu.be/SxUU3zncVmI
 Grading ID - B3590
 CIS 199-75
 Program 4 
 Program Description - Remove Kebab. Users input data This program creates a list of Library books by title and a details 
                                     button that lets users see more about a book.
 Pun of the Program - "Why can't you trust a book?"
                      "Because it comes from a LIEbrary!"
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

namespace Program4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<LibraryBook> bookList = new List<LibraryBook>();//To store the library book objects

        //Precondition  : titleTxtBox.Text has a string value
        //                authorTxtBox.Text has a string value
        //                publisherTxtBox.Text has a string value
        //                copyrightTxtBox.Text integer value >= 0
        //                callNoTxtBox.Text hasa string value
        //Postcondition : Adds a LibraryBook object to bookList
        //                Adds the title of the book to bookListBox
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            int copyright; //to hold the value of copyrightTxtBox.Text when parsed.

            //Validating text boxes
            if (!string.IsNullOrWhiteSpace(titleTxtBox.Text) &&
                !string.IsNullOrWhiteSpace(authorTxtBox.Text) &&
                !string.IsNullOrWhiteSpace(publisherTxtBox.Text) &&
                int.TryParse(copyrightTxtBox.Text, out copyright) &&
                !string.IsNullOrWhiteSpace(callNoTxtBox.Text))
            {
                //Creating a library book object with the fields specified
                LibraryBook newBook = new LibraryBook(titleTxtBox.Text,
                                                      authorTxtBox.Text,
                                                      publisherTxtBox.Text,
                                                      copyright,
                                                      callNoTxtBox.Text);
                bookList.Add(newBook); //adds LibraryBook object to list 
                bookListBox.Items.Add(titleTxtBox.Text); //adds title to listbox
                
                //Clear fields and set focus to first field for easier repeating entry
                titleTxtBox.Clear();
                authorTxtBox.Clear();
                publisherTxtBox.Clear();
                copyrightTxtBox.Clear();
                callNoTxtBox.Clear();
                titleTxtBox.Focus();
            }
            else
                MessageBox.Show("Make sure all fields are valid nerd.");

        }

        //Precondition  : Item selected in bookListBox
        //Postcondition : Shows a MessageBox of the items of that book
        private void detailBtn_Click(object sender, EventArgs e)
        {
            //Validating to make sure the user selected an item in bookListBox
            if (bookListBox.SelectedIndex >= 0)
            {
                //Sees the selected item in bookListBox and finds the corresponding object in bookList and displays its info in a MessageBox
                int index = bookListBox.SelectedIndex;
                MessageBox.Show(bookList[index].ToString());
            }
            else
                MessageBox.Show("Please select an item.");

        }

        //Precondition  : Item selected in bookListBox
        //Postcondition : Changes isCheckedOut to true
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedIndex >= 0)
            {
                int index = bookListBox.SelectedIndex;
                bookList[index].CheckOut();
                MessageBox.Show(CheckedOut(bookList[index].IsCheckedOut()));
            }
            else
                MessageBox.Show("Please Select a Book");
            //Changes the value of isCheckedOut for the corresponding selected object to true and produces a MessageBox to alert the user
            
        }

        //Precondition  : Item selected in bookListBox
        //Postcondition : Changes isCheckedOut to false
        private void returnBtn_Click(object sender, EventArgs e)
        {
            //Changes the value of isCheckedOut for the corresponding selected object to false and produces a MessageBox to alert the user
            if (bookListBox.SelectedIndex >= 0)
            {
                int index = bookListBox.SelectedIndex;
                bookList[index].ReturnToShelf();
                MessageBox.Show(CheckedOut(bookList[index].IsCheckedOut()));
            }
            else
                MessageBox.Show("Please Select a Book");   
        }

        //Precondition  : A bool value in isCheckedOut
        //Postcondition : Gives a meaningful message for the MessageBox to have in checkout/return button
        private string CheckedOut(bool isCheckedOut)
        {
            string output = ""; //To hold a meaningful string representation of isCheckedOut

            //Assigns a meaningful value to string output
            if (bookList[bookListBox.SelectedIndex].IsCheckedOut())
                output = "This Book is Checked Out";
            else
                output = "This Book is Available";

            return output;
        }

        //Precondition  : User wants to have a good time
        //Postcondition : Opens default browser to REMOVE KEBAB
        private void mysteryBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/SxUU3zncVmI");//Open Browser - REMOVE KEBAB
        }
    }
}
