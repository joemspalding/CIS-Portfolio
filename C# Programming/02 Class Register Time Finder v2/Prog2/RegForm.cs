// Program 3
// CIS 199-75
// Due: 10/20/2016
// By: B3590
// Pun of the Program: 
//         Student - "Do you believe in life after death professor?"
//         Prof    - "Maybe, although I don't know why you're asking this question here."
//         Student - "I might need a little more time to finish the homework!"

// This application calculates the earliest registration date
// and time for an undergraduate student given their credit hours
// and last name.
// Decisions based on UofL Fall/Summer 2016 Priority Registration Schedule

// Solution 3
// This solution keeps the first letter of the last name as a char
// and uses if/else logic for the times.
// It uses defined strings for the dates and times to make it easier
// to maintain.
// It only uses programming elements introduced in the text or
// in class.
// This solution takes advantage of the fact that there really are
// only two different time patterns used. One for juniors and seniors
// and one for sophomores and freshmen. The pattern for sophomores
// and freshmen is complicated by the fact the certain letter ranges
// get one date and other letter ranges get another date.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        const float SENIOR_HOURS = 90;    // Min hours for Senior
        const float JUNIOR_HOURS = 60;    // Min hours for Junior
        const float SOPHOMORE_HOURS = 30; // Min hours for Soph.

        const string TIME1 = "8:30 AM";  // 1st time block
        const string TIME2 = "10:00 AM"; // 2nd time block
        const string TIME3 = "11:30 AM"; // 3rd time block
        const string TIME4 = "2:00 PM";  // 4th time block
        const string TIME5 = "4:00 PM";  // 5th time block
        public RegForm()
        {
            InitializeComponent();
        }

        //Precondition : Uppercase char between A & Z, hours >= 0.
        //Postcondition : returns a string with the priority registration time slot.
        private string GetTimeSlot(char initial, double hours)
        {

            string enroll = "Error!"; //string that will be returned. Setting a default value.
            //Priority enrollment times for undergraduates 0=upperclassmen, 1=day1underclassmen, 2=day2underclassmen
            string[,] timeSlot = { { TIME4 , TIME5 , TIME1 , TIME2, TIME3 },
                                   { TIME1 , TIME2 , TIME3, TIME4 , TIME5 },
                                   { TIME2 , TIME3, TIME4 , TIME5 , TIME1 } };

            //Upper character limit of enrollment times for upperclassmen, day1 underclassmen, and day2 underclassmen
            char[,] initialSlot = { { 'D', 'I', 'O', 'S', 'Z'},
                                    { 'L', 'O', 'Q', 'S', 'V'},
                                    { 'B', 'D', 'F', 'I', 'Z'} };

            int i; //used to indicate which dimension we'll look through for range matching time slots
            int j = 0; // used to count through the second dimension for exact time slots.
            bool isFirstDay = true; //differentiating between first day and second day for underclassmen
            int index = initialSlot.GetLength(1); //getting the max length for not crashing with invalid input

            bool found = false; //used to indicate if a match has been found in the search

            //seeing which set underclassmen use
            if (initial <= 'I' || initial >= 'W')
                isFirstDay = false;

            //determining the value of i for range matching time slots.
            if (hours >= JUNIOR_HOURS)
                i = 0;
            else if (isFirstDay)
                i = 1;
            else
                i = 2;

            //range matching
            while (!found && j < index)
            {
                if (initial <= initialSlot[i, j])
                {
                    found = true;
                    enroll = timeSlot[i, j];
                }
                else
                    j++;
            }

            return enroll;
        }

        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
           

            const string DAY1 = "November 4";  // 1st day of registration
            const string DAY2 = "November 7";  // 2nd day of registration
            const string DAY3 = "November 9";  // 3rd day of registration
            const string DAY4 = "November 10"; // 4th day of registration
            const string DAY5 = "November 11"; // 5th day of registration
            const string DAY6 = "November 14"; // 6th day of registration
            
            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            float creditHours;        // Entered credit hours



            if (float.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        // Juniors and Seniors share same schedule but different days
                        if (creditHours >= JUNIOR_HOURS)
                        {
                            if (creditHours >= SENIOR_HOURS)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;
                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE_HOURS)
                            {
                                // J-V on one day
                                if ((lastNameLetterCh >= 'J') && // >= J and
                                    (lastNameLetterCh <= 'V'))   // <= V
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // J-V on one day
                                if ((lastNameLetterCh >= 'J') && // >= J and
                                    (lastNameLetterCh <= 'V'))   // <= V
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }

                        }

                        timeStr = GetTimeSlot(lastNameLetterCh, creditHours);

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // First char not a letter
                        MessageBox.Show("Enter valid last name!");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
            else // Can't parse credit hours
                MessageBox.Show("Please enter valid credit hours earned!");
        }
    }
}
