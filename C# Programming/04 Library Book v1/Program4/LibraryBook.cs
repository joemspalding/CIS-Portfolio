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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //Class used to define what a Library Book is.
    class LibraryBook
    {
        const int DEFAULT_COPYRIGHTYEAR = 2016; //The default value of copyright year if they enter a negative integer.

        private string _title; //Backing field for the Title
        private string _author; //Backing field for the Author
        private string _publisher; //Backing field for the Publisher
        private int _copyrightyear; //Backing field for the CopyrightYear
        private string _callnumber; //Backing field for the CallNumber
        private bool isCheckedOut; //To determine if a book is checked out

        //Constructor for a Library Book
        public LibraryBook(string title, string author, string publisher, int copyrightYear, string callNumber)
        {
            //Assigning values to the members of LibraryBook class
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            CallNumber = callNumber;
            isCheckedOut = false;
        }

        #region Properties
        public string Title
        {
            //Precondition  : None
            //Postcondition : Returns the value in Title
            get
            {
                return _title;
            }
            //Precondition  : A string value
            //Postcondition : Sets the desired string value to the Title property
            set
            {
                _title = value;
            }
        }

        public string Author
        {
            //Precondition  : None
            //Postcondition : Returns the value in Author
            get
            {
                return _author;
            }

            //Precondition  : A string value
            //Postcondition : Sets the desired string value to the Author property
            set
            {
                _author = value;
            }
        }

        public string Publisher
        {
            //Precondition  : None
            //Postcondition : Returns the value in Publisher
            get
            {
                return _publisher;
            }

            //Precondition  : A string value
            //Postcondition : Sets the desired string value to the Publisher property
            set
            {
                _publisher = value;
            }
        }

        public int CopyrightYear
        {
            //Precondition  : None
            //Postcondition : Returns the value in CopyrightYear
            get
            {
                return _copyrightyear;
            }
            //Precondition  : value >= 0
            //Postcondition : Sets a desired valid integer value to value
            //                Sets an invalid integer value to 2016
            set
            {
                if (value >= 0)
                    _copyrightyear = value;
                else
                    _copyrightyear = DEFAULT_COPYRIGHTYEAR;
            }
        }
        public string CallNumber
        {
            //Precondition  : None
            //Postcondition : Returns the value in CallNumber
            get
            {
                return _callnumber;
            }

            //Precondition  : A string value
            //Postcondition : Sets the desired string value to the CallNumber property
            set
            {
                _callnumber = value;
            }
        }
        #endregion
        
        //Precondition  : None
        //Postcondition : Sets isCheckedOut to true
        public void CheckOut()
        {
            isCheckedOut = true;
        }

        //Precondition  : None
        //Postcondition : Sets isCheckedOut to false
        public void ReturnToShelf()
        {
            isCheckedOut = false;
        }

        //Precondition  : isCheckedout has a value
        //Postcondition : Returns the value of isCheckedOut to the user
        public bool IsCheckedOut()
        {
            return isCheckedOut;
        }

        //Precondition  : Valid string in Title
        //                Valid string in Author
        //                Valid string in Publisher
        //                CopyrightYear >= 0
        //                Valid string in CallNumber
        //                bool value in isCheckeOut
        //Postcondition : Returns an string that meaningfully represents a LibraryBook object
        public override string ToString()
        {
            string checkedOut; //string to hold a meaningful representation of bool isCheckedOut
            
            //Using decision making logic to get a meaningful representation of bool isCheckedOut
            if (IsCheckedOut())
                checkedOut = "Yes";
            else
                checkedOut = "No";
            
            
            //Returning a string value
            return "Title : " + Title + Environment.NewLine +
                   "Author : " + Author + Environment.NewLine +
                   "Publisher : " + Publisher + Environment.NewLine +
                   "Copyright Year : " + CopyrightYear.ToString("D4") + Environment.NewLine +
                   "CallNumber : " + CallNumber + Environment.NewLine +
                   "Checked Out : " +  checkedOut;
        }
    }
}
