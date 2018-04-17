/*
 GRADING ID : D2302
 PROGRAM 4
 DUE : APR 19 2017
 CIS 200-01

 DESC : To help sorting by object type, then by title for Sort algorithms.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class TypeTitleAscending : IComparer<LibraryItem>
    {
        // Precondition:  Must be two LibraryItems
        // Postcondition: Returns a positive or negative number based on Type then Title
        public int Compare(LibraryItem item1, LibraryItem item2)
        {
            // Shortcuts for the Type of Item for comparing
            string item1Type = item1.GetType().ToString(); //item1 type shortcut
            string item2Type = item2.GetType().ToString(); //item2 type shortcut

            // Null testing
            if (item1 == null && item2 == null)
                return 0;
            if (item2 == null)
                return -1;
            if (item1 == null)
                return 1;

            // First ASC by type comparison.
            // Then  ASC by title comparison
            if (item1Type.CompareTo(item2Type) != 0)
                return item1Type.CompareTo(item2Type);
            else
                return item1.Title.CompareTo(item2.Title);
        }
    }
}
