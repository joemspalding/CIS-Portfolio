using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)

        {
            // Test Data
            List<LibraryItem> libList = new List<LibraryItem> {
                new LibraryBook("The Wright Guide to C#", "Andrew Wright", "Deitel", 2011, 7, "c#1234"),
                new LibraryMovie("The Good, the Bad, and the Barker", "CIS", 1999, 12, "b4rk3r", 2.5, "Robert Barker", MediaType.VHS, MPAARating.G),
                new LibraryMusic("Tegrity Lecture","Blackboard", 2017, 12, "l3ctur3", 1.2,"Im", MediaType.VINYL, 1),
                new LibraryJournal("GuanDB","Scholastic",2017,8, "gU4nsuff", 12, 12, "Database", "Zurada"),
                new LibraryMagazine("Excel Monthly by Kendra", "=MAX(BEST,WORST,WORST)", 2016, 12, "3xc31", 3, 1)
            };

            LibraryPatron guy1 = new LibraryPatron("Joe Spalding", "abc123");

            //test data
            libList[1].CheckOut(guy1);
            libList[3].CheckOut(guy1);
            libList[1].CalcLateFee(400);
            libList[3].CalcLateFee(400);

            //write it
            foreach (LibraryItem lib in libList)
                Console.WriteLine(lib);
            
                                            
        }
    }
}
