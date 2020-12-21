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
    public partial class NumRevealed : Form
    {
        public NumRevealed()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for when reveal button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnNumReveal_Click(object sender, EventArgs e)
        {
            //Public variable lucky number is assigned to lable and displayed
            lblNumShow.Text = InfoGather.luckyNumber.ToString();
        }
    }
}
