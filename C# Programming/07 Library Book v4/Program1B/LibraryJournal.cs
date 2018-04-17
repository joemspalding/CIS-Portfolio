/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Answers all abstract questions from LibraryPeriodical and
                     LibraryItem. Adds properties for discipline of the journal
                     and for the editor of the journal.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1B
{
    class LibraryJournal : LibraryPeriodical
    {
        const decimal LATE_FEE_RATE = 0.75m; // The rate which the late fee grows daily

        private string _discipline;
        private string _editor;

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        //                  volume >= 0
        //                  issue >= 0
        //                  discipline != null/empty
        //                  editor != null/empty
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryJournal(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber, int volume, int issue, string discipline, string editor)
            : base(title, publisher, copyrightYear, loanPeriod, callNumber, volume, issue)
        {
            Discipline = discipline;
            Editor = editor;
        }
        #region Properties
        public string Discipline
        {
            // Precondition:  None
            // Postcondition: The discipline has been returned
            get
            {
                return _discipline;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The discipline has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _discipline = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Discipline)}", value,
                        $"{nameof(Discipline)} {ValueIsEmptyErrorMessage()}");
            }
        }

        public string Editor
        {
            // Precondition:  None
            // Postcondition: The editor has been returned
            get
            {
                return _discipline;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The editor has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _editor = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} {ValueIsEmptyErrorMessage()}");
            }
        }


        #endregion

        #region Methods
        // Precondition:  A journal must be checked out
        // Postcondition: Returns the Late Fee if current day is later than due date, and returns 0 if thats false.
        public override decimal CalcLateFee(int daysLate) => DoCalcLateFee(daysLate, LATE_FEE_RATE);

        // Precondition:  None
        // Postcondition: Returns a meaningful, formatted string of a LibraryJournal
        protected override string DoToString()
        {
            string NL = Environment.NewLine; // Shortcut for Newline
            return $"Discipline: {Discipline}" + NL +
                $"Editor: {Editor}" + NL +
                base.DoToString();
        }
        #endregion
    }
}
