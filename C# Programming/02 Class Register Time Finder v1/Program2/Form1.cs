/*
 Grading ID - B3590
 CIS 199-75
 Program 2
 Due Oct. 11 2016 (maybe)
 Description - With the last name and credit hours, this program will tell the user their date and time slot to 
               register for clases.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        const float UPPERCLASSMAN_HOUR = 60.0f; //Minimum hours to be an upperclassman
        const float SENIOR_HOUR = 90.0f; //Minimum hours to be a Senior
        const float SOPHOMORE_HOUR = 30.0f; //Minimum hours to be a Sophomore

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            string name = nameTxtBox.Text;     //assign the name to a string variable for easier readability
            char initial;                      //extract and store the first character of their last name for comparisons. 
                                               //this doesn't need tryparse since wacky entries will be handled in the code.
            float hours; //this is to store the parse for hoursTxtBox.Text and for checking academic status.
            bool isFirstDay = false; //This will test to see if an underclassman is to register on day one or day two

            if (float.TryParse(hoursTxtBox.Text, out hours)) //tryparse the hours
            {
                if (hours >= 0) //testing to see if credit hours is non negative
                {
                    if (!string.IsNullOrWhiteSpace(name)) //testing to see if the user input a string into the nameTxtBox
                    {
                        initial = name[0];
                        if (char.IsLetter(initial)) //testing to see if the name starts with a letter
                        {
                            initial = char.ToUpper(initial); //Changes the char to an uppercase letter for comparisons.

                            if (hours >= UPPERCLASSMAN_HOUR)
                            {
                                dateSlotLbl.Text = "Nov. 7"; //setting date lbl to the junior enroll date
                                if (hours >= SENIOR_HOUR) //testing to see if they are a senior as well as an upperclassman
                                    dateSlotLbl.Text = "Nov. 4";

                                //assign a time slot according to  their last name.
                                if (initial <= 'D')
                                    timeSlotLbl.Text = "2:00 PM";
                                else if (initial <= 'I')
                                    timeSlotLbl.Text = "4:00 PM";
                                else if (initial <= 'O')
                                    timeSlotLbl.Text = "8:30 AM";
                                else if (initial <= 'S')
                                    timeSlotLbl.Text = "10:00 AM";
                                else
                                    timeSlotLbl.Text = "11:30 AM";
                            }
                            else //if they aren't upperclassmen, they are underclassmen, so we look at the new time slot algorythm
                            {
                                if (initial >= 'J' && initial <= 'V')
                                    isFirstDay = true; //Testing to see if they register on the first day or second day.

                                //Doing tests to see what day they enroll on.
                                if (isFirstDay && hours >= SOPHOMORE_HOUR)
                                    dateSlotLbl.Text = "Nov. 9";
                                else if (hours >= SOPHOMORE_HOUR)
                                    dateSlotLbl.Text = "Nov. 10";
                                else if (isFirstDay)
                                    dateSlotLbl.Text = "Nov. 11";
                                else
                                    dateSlotLbl.Text = "Nov. 14";

                                //Doing test to see the timeslot underclassmen enroll in
                                if (initial <= 'B')
                                    timeSlotLbl.Text = "10:00 AM";
                                else if (initial <= 'D')
                                    timeSlotLbl.Text = "11:30 AM";
                                else if (initial <= 'F')
                                    timeSlotLbl.Text = "2:00 PM";
                                else if (initial <= 'I')
                                    timeSlotLbl.Text = "4:00 PM";
                                else if (initial <= 'L')
                                    timeSlotLbl.Text = "8:30 AM";
                                else if (initial <= 'O')
                                    timeSlotLbl.Text = "10:00 AM";
                                else if (initial <= 'Q')
                                    timeSlotLbl.Text = "11:30 AM";
                                else if (initial <= 'S')
                                    timeSlotLbl.Text = "2:00 PM";
                                else if (initial <= 'V')
                                    timeSlotLbl.Text = "4:00 PM";
                                else
                                    timeSlotLbl.Text = "8:30 AM";
                            }
                            }
                        else //if the name does not start with a letter
                            MessageBox.Show("Invalid Last Name Input");
                    }

                    else //if they don't enter anything for last name
                        MessageBox.Show("Please input a name");
                }
                else //if the credit hours entered was negative
                    MessageBox.Show("Insert non-negative credit hours");
            }
            else//if the tryparse for hours fails.
                MessageBox.Show("Invalid hours amount");


        }
    }
}
