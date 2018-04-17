/*
 Grading ID - B3590
 Program no. 1
 Due 9-27-16
 CIS 199-75
 DESC - This program is designed to find the total cost of a paint job based on the users inputs.
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

namespace Program1
{
    public partial class paintCostCalculatorForm : Form
    {
        
        public paintCostCalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int FEET_PER_GALLON = 275; //Defines how many square feet you can paint with a single gallon of paint.
            const float HOURS_PER_GALLON = 8.0F;  //Defines how many hours a worker can work for one gallon of paint.
            const float PRICE_PER_HOUR = 12.5F; //Defines the wage of the workers.

            float squareFootageParse; //Used for Parsing squareFootageTextBox.Text
            byte amountOfCoatsParse; //Used for Parsing amountOfCoatsTextBox.Text
            float costPerGallonParse; //Used for Parsing costPerGallonTextBox.Text
            float totalSquareFootage; //Used to hold the Square Footage for squareFootageOutput
            float totalGallonsOfPaint; //Used to hold the Total Gallons of Paint for gallonsOfPaintOutput
            float totalLaborHours; //Used to hold the total labor hours for totalHoursOutput
            float paintTotalCost;   //Used to hold the total cost for paint
            float laborTotalCost;   //Used to hold the total cost for labor
            float totalAmountCost;  //Used to hold the total dollar amount for the paint project

            //Converting the Text Box Strings into float variables
            squareFootageParse = float.Parse(squareFootageTextBox.Text); 
            amountOfCoatsParse = byte.Parse(amountOfCoatsTextBox.Text);
            costPerGallonParse = float.Parse(costPerGallonTextBox.Text);

            //Calculating the number for totalSquareFootageOutput and sending it to the Label
            totalSquareFootage = squareFootageParse * amountOfCoatsParse;
            totalSquareFootageOutput.Text = totalSquareFootage.ToString("f1") + " sq. feet";

            //Calculating the amount of Gallons of paint and sending it to the Label
            totalGallonsOfPaint = totalSquareFootage / (float)FEET_PER_GALLON;
            totalGallonsOfPaint = (float)Math.Ceiling (totalGallonsOfPaint);
            gallonsOfPaintOutput.Text = totalGallonsOfPaint.ToString("f0") + " gallons";

            //Calculating the amount of total labor hours and sending it to the label
            totalLaborHours = totalSquareFootage * (HOURS_PER_GALLON/(float)FEET_PER_GALLON);
            totalHoursOutput.Text = totalLaborHours.ToString("f1") + " hrs";

            //Calculating the total cost for the gallons of paint and sending it to the label
            paintTotalCost = totalGallonsOfPaint * costPerGallonParse;
            paintTotalOutput.Text = paintTotalCost.ToString("c");

            //Calculating the total cost for labor hours and sending it to the label
            laborTotalCost = totalLaborHours * PRICE_PER_HOUR;
            laborTotalOutput.Text = laborTotalCost.ToString("c");

            //Calculating the total cost for the project and sending it to the label
            totalAmountCost = paintTotalCost + laborTotalCost;
            totalAmountOutput.Text = totalAmountCost.ToString("c");
        }
    }
}
