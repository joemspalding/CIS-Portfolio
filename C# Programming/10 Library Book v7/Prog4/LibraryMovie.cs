/*
 GRADING ID : D2302
 PROGRAM 1
 DUE : FEB 15 2017
 CIS 200-01
 CLASS DESCRIPTION : Inherits all functionality from LibraryMediaItem and answers all
                     abstract questions. Also adds a rating enum and property for   
                     additional identification.
 CRACK OF THE CLASS : If you have trouble understanding this code without comments, you may need to adjust the tracking on your VCR.

                    ___..................____
           _..--''~_______   _____...----~~~\\
       __.'    .-'~       \\~      [_`.7     \\
 .---~~      .'            \\           __..--\\_
/             `-._          \\   _...~~~_..---~  ~~~~~~~~~~~~--.._
\              /  ~~~~~~----_\`-~_-~~__          ~~~~~~~---.._    ~--.__
 \     _       |==            |   ~--___--------...__          `-   _.--"""|
  \ __/.-._\   |              |            ~~~~--.  `-._ ___...--~~~_.'|_Y |
   `--'|/~_\\  |              |     _____           _.~~~__..--~~_.-~~~.-~/
     | ||| |\\_|__            |.../.----.._.        | Y |__...--~~_.-~  _/
      ~\\\ || ~|..__---____   |||||  .'~-. \\       |_..-----~~~~   _.~~
        \`-'/ /     ~~~----...|'''|  |/"_"\ \\   |~~'           __.~
         `~~~'                 ~~-:  ||| ~| |\\  |        __..~~
                                   ~~|||  | | \\/  _.---~~
                                     \\\  //  | ~~~
                                      \`-'/  / 
                                       `~~~~'
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    // Data type for ratings
    public enum MPAARating { G, PG, PG13, R, NC17, U };

    class LibraryMovie : LibraryMediaItem
    {
        const decimal MAX_LATE_FEE = 25m;   // The maximum amount for a late fee before it stops accumulating
        private decimal lateFeeRate;        // The rate to calculate the late fee, to be calculated in CalcLateFee()
        private string _director;    // Holds the Director
        private MediaType _medium;   // Holds the Media Type
        private MPAARating _rating;  // Holds the Rating

        // Precondition:    title != null/empty
        //                  publisher != null/empty
        //                  copyrightYear >= 0
        //                  loanPeriod >= 0
        //                  callNumber != null/empty
        //                  duration >= 0
        //                  director != null/empty
        //                  medium == MediaType.CD | MediaType.SACD | MediaType.VINYL
        //                  rating == MPAARating Type
        // Postcondition: Creates an object with specified values, otherwise may throw exceptions
        public LibraryMovie(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber,
            double duration, string director, MediaType medium, MPAARating rating)
            : base(title, publisher, copyrightYear, loanPeriod, callNumber, duration)
        {
            Director = director;
            Medium = medium;
            Rating = rating;
        }

        #region Properties
        public string Director
        {
            // Precondition:  None
            // Postcondition: The director has been returned
            get
            {
                return _director;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The director has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _director = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                        $"{nameof(Director)} {ValueIsEmptyErrorMessage()}");
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
                if (value == MediaType.DVD || value == MediaType.BLURAY || value == MediaType.VHS)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                        $"{nameof(Medium)} is not a a DVD, BLURAY, or VHS");
            }
        }

        public MPAARating Rating
        {
            // Precondition:  None
            // Postcondition: The rating has been returned
            get
            {
                return _rating;
            }
            // Precondition:  value must be a valid rating
            // Postcondition: The rating has been set to the specified value
            set
            {
                if (Enum.IsDefined(typeof(MPAARating), value))
                    _rating = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Rating)}", value,
                        $"{nameof(Rating)} is not a valid rating.");
            }
        }
        #endregion

        #region Methods
        // Precondition:  A movie must be checked out
        // Postcondition: Returns the Late Fee if current day is later than due date but less than the maximum amount, and returns 0 if thats false.
        public override decimal CalcLateFee(int daysLate)
        {
            lateFeeRate = (Medium == MediaType.BLURAY) ? 1.5m : 1.0m; // Determining the late fee rate
            return DoCalcLateFee(daysLate, lateFeeRate, MAX_LATE_FEE);
        }

        // Precondition:  None
        // Postcondition: Returns a meaningful, formatted string of a LibraryMovie
        protected override string DoToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            // Formatting
            return $"Director: {Director} {NL}" +
                $"Medium: {Medium} {NL}" +
                $"Rating: {Rating} {NL}" +
                base.DoToString();
        }
        #endregion

    }
}
