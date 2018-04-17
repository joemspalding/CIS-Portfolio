/*
 ID - D2302
 PROGRAM 1B
 DUE 2/23/17
 CIS 200-01
 DESC - This program exists to test the class hierarchy and to show the utility 
        of LINQ by modifying lists with queries.
 
 PUN OF THE PROGRAM - Have you heard of the new social networking site where .NET developers and DBAs get together?
                      It's called LINQdIn!
                      (yes, this is seriously the best thing i could come up with...)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1B
{
    class Program
    {
        // Precondition:  None
        // Postcondition: The console pauses output for a second
        public static void Pause()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method
            const int LOANPERIODINCREASE = 7; // Number of days to increase loan period by later
            
            List<LibraryItem> items = new List<LibraryItem>();       // List of library items
            List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

            // Test data - Magic numbers allowed here
            items.Add(new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press", 2010, 14,
                "ZZ25 3G"));
            items.Add(new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books", 2000, 21,
                "AB73 ZF"));
            items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", MediaType.BLURAY, MPAARating.PG));
            items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
                "MO93 4S", 122.5, "Steven Stealberg", MediaType.DVD, MPAARating.G));
            items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", MediaType.CD, 10));
            items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", MediaType.VINYL, 12));
            items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
            items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
            items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9A", 16, 7));
            items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9B", 16, 8));
            items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9C", 16, 9));
            items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
                "MA21 5V", 1, 1));

            // Add patrons
            patrons.Add(new LibraryPatron("Ima Reader", "12345"));
            patrons.Add(new LibraryPatron("Jane Doe", "11223"));
            patrons.Add(new LibraryPatron("John Smith", "54321"));
            patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
            patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));


            // Listing the original items list
            foreach (LibraryItem item in items)
                Console.WriteLine(item);
            Pause();

            // Listing the original patrons list
            foreach (LibraryPatron patron in patrons)
                Console.WriteLine(patron);
            Pause();

            // Checking out books per instructions
            items[1].CheckOut(patrons[0]);
            items[3].CheckOut(patrons[1]);
            items[5].CheckOut(patrons[2]);
            items[7].CheckOut(patrons[3]);
            items[9].CheckOut(patrons[4]);

            // Finding the checked out items from the original list
            var checkOutFilter =
                from item in items
                where item.IsCheckedOut()
                select item;

            // Listing the items that are checked out
            foreach (LibraryItem item in checkOutFilter)
                Console.WriteLine(item);
            Console.WriteLine(checkOutFilter.Count());
            Pause();
                        
            // Finding the mediaitems that are checked out
            var mediaFilter =
                from item in checkOutFilter
                where item as LibraryMediaItem != null
                select item;
            
            // Listing the mediaitems from checked out
            foreach (LibraryMediaItem item in mediaFilter)
                Console.WriteLine(item);
            Pause();

            // Finding the distinct magazine title names
            var uniqueMags =
               (from item in items
                where item as LibraryMagazine != null
                orderby item.Title
                select item.Title).Distinct();

            // Output
            foreach (var item in uniqueMags)
                Console.WriteLine(item);
            Pause();

            // Calculating Late Fee and outputting to the console
            for (int i = 0; i<items.Count; i++)
            {
                items[i].CalcLateFee(DAYSLATE);
                Console.WriteLine(items[i]);
            }
            Pause();

            // Returning all books
            foreach (LibraryItem item in items)
                item.ReturnToShelf();
            // Filtering out the checked out items
            checkOutFilter =
                from item in items
                where item.IsCheckedOut()
                select item;
            // Write that out homie
            Console.WriteLine(checkOutFilter.Count());
            Pause();

            // Outputting the current loan period
            foreach (LibraryItem item in items)
                Console.WriteLine(item.LoanPeriod);

            // Increasing the loan period and outputting it to the console
            foreach (LibraryItem item in items)
            {
                item.LoanPeriod = item.LoanPeriod + LOANPERIODINCREASE;
                Console.WriteLine(item.LoanPeriod);
            }

            // Outputting the items for the last time
            foreach (LibraryItem item in items)
                Console.WriteLine(item);


        }
    }
}
