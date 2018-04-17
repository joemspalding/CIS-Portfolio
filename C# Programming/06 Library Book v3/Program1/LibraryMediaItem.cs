/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Inherits functionality from LibraryItem, but provides a more 
                     specific template for media items in particular, such as an 
                     enum for the type of media and a duration property. Requests  
                     derived classes to know what type of media they are as a property.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    // Data type for media type
    public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL };

    abstract class LibraryMediaItem : LibraryItem
    {
        private double _duration; // Holds the duration

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        //                  duration >= 0
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryMediaItem (string title, string publisher, int copyrightYear, int loanPeriod, string callNumber, double duration)
            : base (title, publisher, copyrightYear, loanPeriod, callNumber)
        {
            Duration = duration;
        }

        #region Properties
        public double Duration
        {
            // Precondition:  None
            // Postcondition: The duration has been returned
            get
            {
                return _duration;
            }
            // Precondition:  value >= 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} {ValueIsLessThan0ErrorMessage()}");
                _duration = value;
            }
        }

        public abstract MediaType Medium
        {
            get; set;
        }
        #endregion

        #region Methods
        // Precondition:  None
        // Postcondition: Template formatting for child LibraryMediaItems
        protected override string DoToString()
        {
            // Formatting
            return $"Duration: {Duration}";             
        }
        #endregion
    }
}
