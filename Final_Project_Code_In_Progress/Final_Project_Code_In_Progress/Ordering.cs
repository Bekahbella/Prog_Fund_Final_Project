using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Project_Code_In_Progress
{
    public partial class Ordering : Form
    {
  //Declarations
            bool takeOut;
            string bunType = "";
            int pattyNum;
            string orderStep; //keeps track of current pannel

            Array[] cheeseType;
            Array[] toppings;
            Array[] sauce;
            Array[] optionsArray;
        
        
        
        public Ordering()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pnlStart.Visible = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPreviousNext.Visible = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPreviousNext.Visible = true;

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
 
            takeOut = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPreviousNext.Visible = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            switch (orderStep)
            {
                case "orderType":
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }

       
        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "location";
            }

        }
        

        }
    }

