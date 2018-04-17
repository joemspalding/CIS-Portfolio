/*
 GRADING ID : D2302
 PROGRAM 4
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Represents a book in the library. Adds an Author property and completes 
                     the methods LibraryItem requests.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class LibraryBook : LibraryItem
    {
        private const decimal LATE_FEE_RATE = .25m;  // The price per day on late fees
        private string _author;                      // Holds the Author

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryBook(string title, string author, string publisher, int copyrightYear, int loanPeriod, string callNumber)
            : base(title, publisher, copyrightYear, loanPeriod, callNumber)
        {
            Author = author;
        }

        #region Properties
        public string Author
        {
            // Precondition:  None
            // Postcondition: The current value of Author will be returned
            get
            {
                return _author;
            }
            // Precondition:  None
            // Postcondition: If the value is null, sets _author to an empty string, otherwise sets it to a trimmed string of value
            set
            {
                _author = (value == null ? string.Empty : value.Trim());
            }
        }
        #endregion

        #region Methods
        // Precondition:  A book must be checked out
        // Postcondition: Returns the Late Fee if current day is later than due date, and returns 0 if thats false.
        public override decimal CalcLateFee(int daysLate) => DoCalcLateFee(daysLate, LATE_FEE_RATE);

        // Precondition:  None
        // Postcondition: Returns a meaningful, formatted string of a LibraryBook
        protected override string DoToString()
        {
            //Formatting
            return $"Author: {Author}";
        }
        #endregion

    }
}
