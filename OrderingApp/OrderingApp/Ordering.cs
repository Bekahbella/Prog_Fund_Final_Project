using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class Ordering : Form
    {
        string message = "Button Clicked!";
        public Ordering()
        {
            InitializeComponent();
       

        }

        private void Ordering_Load(object sender, EventArgs e) 
        {
            lblOutput.Text = ""; //Populated with a blank string until button is clicked
        }

        private void bntOne_Click(object sender, EventArgs e)
        {
            //lblOutput.Text = "Button Clicked!"; //setting label output to the string
            lblOutput.Text = message; //declare it as a variable for multiple uses
        }

       

       

       
    }
}
