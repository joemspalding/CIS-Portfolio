/*
 GRADING ID : D2302
 PROGRAM 4
 DUE : APR 19 2017
 CIS 200-01

 DESC : To help sorting by copyright year descending Sort algorithms.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class DescendingCopyright : IComparer<LibraryItem>
    {
        // Precondition:  Must be two LibraryItems
        // Postcondition: Returns a positive or negative number based on the comparison of two copyright years
        public int Compare (LibraryItem item1, LibraryItem item2)
        {
            // Null testing
            if (item1 == null && item2 == null)
                return 0;
            if (item2 == null)
                return -1;
            if (item1 == null)
                return 1;

            // Returing the inverse of an int.CompareTo() for descending order.
            return (-1) * item1.CopyrightYear.CompareTo(item2.CopyrightYear);
        }
    }
}
