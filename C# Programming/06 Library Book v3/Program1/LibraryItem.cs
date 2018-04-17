/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : To serve as a base class from which all other library items are inherited.
                     Contains identifying properties that every library item has and functionality every library item has
                     and requests only to find out to calculate late fees and fill out a component of ToString().
                     Also records due date and who checked out the item in question.

  ____________________________________________________
  |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |NET|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____|
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ | /  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    abstract class LibraryItem
    {
        private string _title;        // Holds the Title
        private string _publisher;    // Holds the Publisher
        private int _copyrightYear;   // Holds the Copyright Year
        private int _loanPeriod;      // Holds the Loan Period
        private string _callNumber;   // Holds thd Call Number
        private bool _checkedOut;     // Holds the Checked Out Status
        private int daysLate;         // Holds the amount of days late

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryItem(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber)
        {
            //Initialize Values
            Title = title;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            LoanPeriod = loanPeriod;
            CallNumber = callNumber;
            ReturnToShelf(); //Make sure the item is not checked out
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

            // Precondition:  value must not be null or empty
            // Postcondition: The title has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _title = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                        $"{nameof(Title)} {ValueIsEmptyErrorMessage()}");
            }
        }

        public string Publisher
        {
            // Precondition:  None
            // Postcondition: The current value of Author will be returned
            get
            {
                return _publisher;
            }
            // Precondition:  None
            // Postcondition: If the value is null, sets _publisher to an empty string, otherwise sets it to a trimmed string of value
            set
            {
                _publisher = (value == null ? string.Empty : value.Trim());
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
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} {ValueIsLessThan0ErrorMessage()}");
            }
        }

        public int LoanPeriod
        {
            // Precondition:  None
            // Postcondition: The loan period has been returned
            get
            {
                return _loanPeriod;
            }

            // Precondition:  value >= 0
            // Postcondition: The loan period has been set to the specified value
            set
            {
                if (value >= 0)
                    _loanPeriod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} {ValueIsLessThan0ErrorMessage()}");
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

            // Precondition:  value must not be null or empty
            // Postcondition: The call number has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _callNumber = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                        $"{nameof(CallNumber)} {ValueIsEmptyErrorMessage()}");
            }
        }

        public LibraryPatron Patron
        {
            // Precondition:  None
            // Postcondition: The book's patron has been returned
            get; // Auto-implement is fine

            // Helper
            // Precondition:  None
            // Postcondition: The book's patron has been set to the specified value
            private set; // Auto-implement is fine 
        }

        #endregion

        #region Methods
        // Precondition:  None
        // Postcondition: Returns an error message for empty/null strings
        protected string ValueIsEmptyErrorMessage() => "must not be null or empty";

        // Precondition:  None
        // Postcondition: Returns an error message for negative values.
        protected string ValueIsLessThan0ErrorMessage() => "must be >= 0";
        
        // Precondition:  thePatron != null
        // Postcondition: The book is checked out
        public virtual void CheckOut(LibraryPatron thePatron)
        {
            _checkedOut = true;
            if (thePatron != null)
            {
                Patron = thePatron;
            }
            else
                throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
        }

        // Precondition:  None
        // Postcondition: The book is not checked out
        public void ReturnToShelf()
        {
            _checkedOut = false;
            Patron = null; // Remove previously stored reference to patron
        }

        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return _checkedOut;
        }

        // Precondition:  Unknown
        // Postcondition: Calculates the Late Fee for a library item
        public abstract decimal CalcLateFee(int days);

        // Precondition:  days >= 0
        //                rate >= 0
        //                _checkedOut = true
        // Postcondition: Calculates the late fee. 
        protected decimal DoCalcLateFee(int days, decimal rate, decimal max = -1)
        {
            // Testing to see the book is checkedout.
            if (_checkedOut)
            {
                //Error Checking
                if (days >= 0)
                {
                    if (rate >= 0)
                    {
                        decimal lateFee = rate * days; // Getting late fee
                        daysLate = days; // storing to field variable

                        // Test to see if user input anything for max.
                        // If they have a max value and if the max value is less than the late fee 
                        // is the only condition when we modify the calculation.
                        if (max != -1 && max < lateFee)
                            lateFee = max;
                        return lateFee;
                    }
                    // exception if rate is < 0
                    else
                        throw new ArgumentOutOfRangeException(nameof(rate), rate,
                            $"{nameof(rate)} {ValueIsLessThan0ErrorMessage()}");
                }
                // exception if days is < 0
                else
                    throw new ArgumentOutOfRangeException(nameof(days), days,
                        $"{nameof(days)} {ValueIsLessThan0ErrorMessage()}");
            }
            return 0;
        }

        // Precondition:  None
        // Postcondition: Template formatting for child LibraryItems
        public override string ToString()
        {
            string NL = Environment.NewLine; //NewLine Shortcut

            //Formatting
            return "Title: " + Title + NL +
                DoToString() + NL +
                "Publisher: " + Publisher + NL +
                "Copyright: " + CopyrightYear.ToString("D4") + NL +
                "Call Number: " + CallNumber + NL +
                "Checked Out: " + IsCheckedOut().ToString() + NL + 
                CheckOutResult();
        }

        // Precondition:  None
        // Postcondition: Returns a string that results in a cleaner ToString method
        protected abstract string DoToString();

        // Precondition:  None
        // Postcondition: Returns a formatted string to represent the checkedout metadata like who, duedate, and latefees (if applicable)
        protected string CheckOutResult()
        {
            string NL = Environment.NewLine; //NewLine Shortcut
            string checkOutResult; // Used to store the formatted patron info, due date, and late fee if applicable

            //testing to see if the book is checked out to find who checked it out, when it is due, and if applicable, what the late fee is.
            if (IsCheckedOut())
                checkOutResult = $"Checked Out By: {Patron.ToString()}" + NL +
                    $"{((CalcLateFee(daysLate) > 0) ? $"Late Fee: {CalcLateFee(daysLate):C}" : "")}"; 
            else
                checkOutResult = "Checked Out By: This book is available.";

            return checkOutResult + NL;
        }
        #endregion

    }
}