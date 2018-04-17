/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Inherits all functionality from LibraryMediaItem and answers all
                     abstract questions. Additionally adds properties for artist and 
                     number of tracks.
 CRACK OF THE CLASS : "Ugh, C# is so mainstream. I only listen to VBA - Vinyl Based Audio..."

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class LibraryMusic : LibraryMediaItem
    {
        const decimal MAX_LATE_FEE = 20.0m; // The maximum late fee before it stops accumulating
        const decimal LATE_FEE_RATE = 0.5m; // The rate which the late fee grows daily

        private string _artist;     // Holds the author
        private MediaType _medium;  // Holds the media type
        private int _tracks;        // Holds the track number

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        //                  duration >= 0
        //                  artist != null/empty
        //                  medium == MediaType.CD | MediaType.SACD | MediaType.VINYL
        //                  tracks >= 1
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryMusic(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber, double duration, string artist, MediaType medium, int tracks)
            : base(title, publisher, copyrightYear, loanPeriod, callNumber, duration)
        {
            Artist = artist;
            Medium = medium;
            Tracks = tracks;
        }

        #region Properties
        public string Artist
        {
            // Precondition:  None
            // Postcondition: The artist has been returned
            get
            {
                return _artist;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The artist has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _artist = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Artist)}", value,
                        $"{nameof(Artist)} {ValueIsEmptyErrorMessage()}");
            }

        }

        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The media type has been returned
            get
            {
                return _medium;
            }

            // Precondition:  value must be a DVD, BLURAY, or VHS
            // Postcondition: The mediatype has been set to the specified value
            set
            {
                if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                        $"{nameof(Medium)} is not a a CD, SACD, or VINYL");
            }
        }

        public int Tracks
        {
            // Precondition:  None
            // Postcondition: The track number has been returned
            get
            {
                return _tracks;
            }
            // Precondition:  value >= 1
            // Postcondition: The track number has been set to the specified value
            set
            {
                if (value >= 1)
                    _tracks = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Tracks)}", value,
                        $"{nameof(Tracks)} must be >= 1");
            }
        }

        #endregion

        #region Methods
        // Precondition:  A music item must be checked out
        // Postcondition: Returns the Late Fee if current day is later than due date but less than the maximum amount, and returns 0 if thats false.
        public override decimal CalcLateFee(int daysLate) => DoCalcLateFee(daysLate, LATE_FEE_RATE, MAX_LATE_FEE);

        // Precondition:  None
        // Postcondition: Returns a meaningful, formatted string of a LibraryMusic
        protected override string DoToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            // Formatting
            return $"Artist: {Artist} {NL}" +
                $"Track Number: {Tracks} {NL}" +
                $"Medium: {Medium}{NL}" +
                base.DoToString();
        }
        #endregion
    }
}
