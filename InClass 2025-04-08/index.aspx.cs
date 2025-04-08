using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass_2025_04_08
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmdOK.Click += cmdOK_Click1;
        }

        protected void cmdOK_Click1(object sender, EventArgs e)
        {
            // Our code goes here

            // Compute the number of days between the two calendar controls
            // Multiply that value by $200 (per day)
            // Apply 15% sales tax to that total
            // Display the total with tax in our label
            
            DateTime d1 = calCheckInDate.SelectedDate;
            DateTime d2 = calCheckOutDate.SelectedDate;
            TimeSpan difference = d2 - d1;
            var days = difference.Days;

            int charge = days * 200;

            double total = charge * 1.15;

            

            lblResult.Text = "The total amount for the stay is $" + total.ToString();
        }
    }
}