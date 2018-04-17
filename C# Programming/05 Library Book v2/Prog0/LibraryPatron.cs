/*
 GRADING ID - D2302
 Program 0
 Due - Jan 1 2017
 CIS 200-01
 File: LibraryPatron.cs
 This file creates a simple LibraryPatron class capable of tracking
 the patron's name and ID.

 CRACK OF THE CLASS - Why did the library patron start checking out detective novels?
                      Nobody knows, it's a mystery!
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron
    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }

    #region Properties
    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  The patron's name must not be empty or whitespace
        // Postcondition: The patron's name has been set to the specified value
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(this.PatronName)} {StringIsEmptyErrorMessage()}");

            _patronName = value;
        }
    }

    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  The patron's ID must not be empty or whitespace
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(this.PatronID)} {StringIsEmptyErrorMessage()}");
            _patronID = value;
        }
    }
    #endregion

    // Precondition:  String value is the name of a property.
    // Postcondition: Returns a string to deal with string properties being invalid.
    private string StringIsEmptyErrorMessage() => "is white space, empty or otherwise invalid.";

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}

