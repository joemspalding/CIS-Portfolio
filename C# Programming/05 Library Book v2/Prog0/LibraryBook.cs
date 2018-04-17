/*
 GRADING ID - D2302
 Program 0
 Due - Jan 1 2017
 CIS 200-01
 File: LibraryBook.cs
 This file creates a simple LibraryBook class capable of tracking
 the book's title, author, publisher, copyright year, call number,
 and checked out status. It creates a LibraryPatron object to keep
 track of who checked out a book.

 CRACK OF THE CLASS - Why did the pregnant lady have to return her library books late?
                      Because she was overdue!
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2016; // Default copyright year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private LibraryPatron _patron; // When a book is checked out, it creates this object to remember who has it.
                                   // Will be null if the book is not checked out.
    private bool _checkedOut;   // The book's checked out status

    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(string theTitle, string theAuthor, string thePublisher,
        int theCopyrightYear, string theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    #region Properties
    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  The title must not be empty or whitespace
        // Postcondition: The title has been set to the specified value
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(this.Title)} {StringIsEmptyErrorMessage()}");
            _title = value;
        }
    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  The author must not be empty or whitespace
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public string Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(this.Publisher)} {StringIsEmptyErrorMessage()}");
            _publisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
            else
                throw new ArgumentOutOfRangeException (nameof(value),value, $"{nameof(CopyrightYear)} is not greater than or equal to 0");
        }
    }

    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(this.CallNumber)} {StringIsEmptyErrorMessage()}");
            _callNumber = value;
        }
    }

    public LibraryPatron Patron
    {
        //Precondition:  _checkedOut is true.
        //Postcondition: The patron object associated with this object will be returned. Null will be returned otherwise.
        get
        {
            if (_checkedOut)
                return _patron;
            else
                return null;
        }
        //Precondition:  Can only be used in the CheckOut or ReturnToShelf methods.
        //Postcondition: The Patron object has been set to the specified value.
        private set
        {
            _patron = value; 
        }
    }
    #endregion

    // Precondition:  String value is the name of a property.
    // Postcondition: Returns a string to deal with string properties being invalid.
    private string StringIsEmptyErrorMessage() => "is white space, empty, or null.";

    #region Check Out Methods
    // Precondition:  None
    // Postcondition: The book is checked out
    public void CheckOut(LibraryPatron patron)
    {
        Patron = patron;
        _checkedOut = true;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        Patron = null;
        _checkedOut = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }
    #endregion

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
        string checkOutResult; // Used to store the LibraryPatron data in the return 

        //testing to see if the book is checked out and formatting the LibraryPatron object appropriately to this class
        if (_checkedOut)
            checkOutResult = System.Environment.NewLine + $"Checked Out By: {Patron.PatronName}, ID: {Patron.PatronID}";
        else
            checkOutResult = System.Environment.NewLine + "Checked Out By: This book is not checked out by anyone.";

        return "Title: " + Title + System.Environment.NewLine +
            "Author: " + Author + System.Environment.NewLine +
            "Publisher: " + Publisher + System.Environment.NewLine +
            "Copyright: " + CopyrightYear.ToString("D4") + System.Environment.NewLine +
            "Checked Out: " + IsCheckedOut().ToString() +
            checkOutResult;
    }
}