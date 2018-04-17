/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Inherits functionality from LibraryItem, but provides a more 
                     specific template for periodical items in particular, such as 
                     properties for volume and issue numbers. 
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1B
{
    abstract class LibraryPeriodical : LibraryItem
    {
        private int _volume; // Holds the volume
        private int _issue; // Holds the issue

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        //                  volume >= 0
        //                  issue >= 0
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryPeriodical(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber, int volume, int issue)
            : base(title, publisher, copyrightYear, loanPeriod, callNumber)
        {
            Volume = volume;
            Issue = issue;
        }

        #region Properties
        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume has been returned
            get
            {
                return _volume;
            }
            // Precondition:  value >= 0
            // Postcondition: The volume has been set to the specified value
            set
            {
                if (value >= 0)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                        $"{nameof(Volume)} {ValueIsLessThan0ErrorMessage()}");

            }
        }

        public int Issue
        {
            // Precondition:  None
            // Postcondition: The issue has been returned
            get
            {
                return _issue;
            }
            // Precondition:  value >= 0
            // Postcondition: The issue has been set to the specified value
            set
            {
                if (value >= 0)
                    _issue = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Issue)}", value,
                        $"{nameof(Issue)} {ValueIsLessThan0ErrorMessage()}");
            }
        }
        #endregion

        #region Methods
        // Precondition:  None
        // Postcondition: Template formatting for child LibraryPeriodicals
        protected override string DoToString()
        {
            string NL = Environment.NewLine; // Shortcut 
            return $"Volume: {Volume}{NL}" +
                $"Issue: {Issue}";
        }
        #endregion
    }
}
