using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutOfClassAssignment5
{
    public partial class InfoGather : Form
    {
        //Declaring public variable for lucky number
        public static int luckyNumber;

        public InfoGather()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when lucky number button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnGetNumber_Click(object sender, EventArgs e)
        {
            //Declaring variables with user input
            int birthYear = Convert.ToInt32(txtDay.Text);
            string birthMonth = cboBirth.SelectedItem.ToString();
            int birthDay = Convert.ToInt32(txtDay.Text);
            string favColor = cboColor.SelectedItem.ToString();

            //Calling method for year, assigns returned number to variable
            InfoInterpret yearNum = new InfoInterpret();

            int luckNum1 = yearNum.convertYear(birthYear);


            //Calling method for month, assigns returned number to variable
            InfoInterpret monthNum = new InfoInterpret();

            int luckNum2 = monthNum.convertMonth(birthMonth);


            //Calling method for day, assigns returned number to variable
            InfoInterpret dayNum = new InfoInterpret();

            int luckNum3 = dayNum.convertDay(birthDay);


            //Calling method for color, assigns returned number to variable
            InfoInterpret colorNum = new InfoInterpret();

            int luckNum4 = colorNum.convertColor(favColor);


            //Using values from methods to calculate a random number
           luckyNumber = ((luckNum1 + luckNum2) - luckNum3) / luckNum4;


            //Open Reveal form
            NumRevealed openForm = new NumRevealed();
            openForm.Show();



        }
    }
}
