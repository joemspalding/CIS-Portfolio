/*
 GRADING ID : D2302
 PROGRAM 4
 DUE : APR 19 2017
 CIS 200-01

 DESC : To demonstrate sorting algorithms and their use of .CompareTo() methods/ different IComparer<T> classes.
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LibraryItem> itemList = new List<LibraryItem>(); // List to sort stuff with

            //Sample data
            itemList.Add(new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press", 2010, 14, "ZZ25 3G"));
            itemList.Add(new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books", 2000, 21, "AB73 ZF"));
            itemList.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7, "MM33 2D", 92.5, "Andrew L. Wright", MediaType.BLURAY, MPAARating.PG));
            itemList.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10, "MO93 4S", 122.5, "Steven Stealberg", MediaType.DVD, MPAARating.G));
            itemList.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14, "CD44 4Z", 84.3, "Dr. A", MediaType.CD, 10));
            itemList.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21, "VI64 1Z", 65.0, "Cee Sharpe", MediaType.VINYL, 12));
            itemList.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14, "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
            itemList.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14, "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
            itemList.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9A", 16, 7));
            itemList.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9B", 16, 8));
            itemList.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9C", 16, 9));
            itemList.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2017, 14, "MA21 5V", 1, 1));


            Console.WriteLine("Testing Default Sort\n");

            itemList.Sort(); //Do the default sort for LibraryItem (ASC by Title)

            //Show that it worked. 
            foreach (LibraryItem i in itemList)
            {
                Console.WriteLine(i.Title);
            }
            Console.WriteLine(Environment.NewLine);

            itemList.Sort(new DescendingCopyright()); //Do an alternative sort (DESC by CopyrightYear)

            //Show that it worked.
            foreach (LibraryItem i in itemList)
            {
                Console.WriteLine(i.CopyrightYear);
            }
            Console.WriteLine(Environment.NewLine);

            itemList.Sort(new TypeTitleAscending()); //Do another alternative sort (ASC by type; ASC by Title)

            //Show that it worked
            foreach (LibraryItem i in itemList)
            {
                Console.WriteLine($"{i.GetType().ToString().Substring(6)}, {i.Title}");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
