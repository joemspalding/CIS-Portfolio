/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Answers all abstract questions from LibraryPeriodical and
                     LibraryItem. Does not add anything new, more or less a    
                     concrete version of LibraryPeriodical.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class LibraryMagazine : LibraryPeriodical
    {
        const decimal MAX_LATE_FEE = 20m; // The maximum late fee before it stops accumulating
        const decimal LATE_FEE_RATE = .25m; // The rate which the late fee grows daily

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        //                  volume >= 0
        //                  issue >= 0
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryMagazine(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber, int volume, int issue)
            : base(title, publisher, copyrightYear, loanPeriod, callNumber, volume, issue) { }


        #region Methods
        // Precondition:  A magazine must be checked out
        // Postcondition: Returns the Late Fee if current day is later than due date but less than the maximum amount, and returns 0 if thats false.
        public override decimal CalcLateFee(int daysLate) => DoCalcLateFee(daysLate, LATE_FEE_RATE, MAX_LATE_FEE);

        #endregion
    }
}
