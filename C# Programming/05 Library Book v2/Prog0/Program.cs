/*
 GRADING ID - D2302
 Program 0
 Due - Jan 1 2017
 CIS 200-01
 File: Program.cs
 This file creates a simple test application class that creates
 a list of LibraryBook objects and tests them.

 PUN OF THE PROGRAM - Why did the librarian have to skip out on dinner?
                      Because she was booked!
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Way to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Dank Meme", " blob ", "Stealer Books",
            2001, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            1994, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

        LibraryPatron patron1 = new LibraryPatron("Steak Lover", "A1-5t34k"); //1st test patron
        LibraryPatron patron2 = new LibraryPatron("Chris Cole", "N1-fr13d"); //2nd test patron
        LibraryPatron patron3 = new LibraryPatron("Party McLarty", "W3-p4rt3"); //3rd test patron

        List < LibraryBook > theBooks = new List<LibraryBook>();
        theBooks.Add(book1);
        theBooks.Add(book2);
        theBooks.Add(book3);
        theBooks.Add(book4);
        theBooks.Add(book5);

        Console.WriteLine("Original list of books\n");
        PrintBooks(theBooks);

        // Make changes
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);

        Console.WriteLine("After changes\n");
        PrintBooks(theBooks);

        // Return all the books
        for (int i = 0; i < theBooks.Count; ++i)
            theBooks[i].ReturnToShelf();

        Console.WriteLine("After returning the books\n");
        PrintBooks(theBooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)
    {
        foreach (LibraryBook b in books)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }
    }
}
