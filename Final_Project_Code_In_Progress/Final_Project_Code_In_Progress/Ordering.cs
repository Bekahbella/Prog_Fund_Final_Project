﻿using System;
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
        //string bunType = "";
        int pattyNum;
        string orderStep; //keeps track of current pannel

        
        string [] toppings = new string[] {};
        string [] sauce = new string[] {};
        string [] optionsArray = new string [4];
        string bunType;
        string cheeseType;


        public Ordering()
        {
            InitializeComponent();
        }
        //Application Load Event

        private void Form1_Load(object sender, EventArgs e) //all things you change programmatically
        {

            pnlStart.Visible = true;
            //Hide all panels
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPreviousNext.Visible = true;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;

            lblStack.Text = "";



        }

        //Panel Visible Changed Events //panel is object changes from load event true

        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderStep = "start";
            }

        }


        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderStep = "location";
            }

        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e) //tells program what pannel it is on so we know our location in the application
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "ordertype";
            }
        }
    

        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {

            if (pnlBuild.Visible == true)
            {
                orderStep = "build";
                
            }

            btnNext.Visible = false;
        }


        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            {
                orderStep = "bun";
                btnNext.Enabled = false; //button is there but you can't click on it

                if (optionsArray[0] == "") //if array position 0 is equal to an empty array do parenthesis
                {
                    btnNext.Enabled = true; //continue button will be enabled
                }
            }
        }

        private void pnCheese_VisibleChanged(object sender, EventArgs e)
        {

            if (pnlCheese.Visible == true)
            {
                orderStep = "cheese";
                btnNext.Enabled = false; //must select type before moving on
                if (optionsArray[1] == "")
                {
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }
                
            }
        }

        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible == true)
            {
                orderStep = "toppings";
                btnNext.Enabled = false; //must select type before moving on
                if (optionsArray[2] == "")
                {
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }

            }
        }

        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {

            if (pnlSauce.Visible == true)
            {
                orderStep = "sauce";
                btnNext.Enabled = false; //must select type before moving on
                if (optionsArray[3] == "")
                {
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }

            }
        }

        //Button Click Events

        //pnl 1 Start button clicks
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPreviousNext.Visible = true;
        }

        //pnl 2 Location button clicks
        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;

            pnlLocation.Visible = false;

            pnlOrderType.Visible = true;

            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;

        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            takeOut = true;

            pnlLocation.Visible = false;

            pnlOrderType.Visible = true;

            pnlPreviousNext.Visible = true;
        }

        //pnl 3 Build panel button clicks
        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            //pnlBun.Visible = true;
            pnlBuild.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPreviousNext.Visible = true;


        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPreviousNext.Visible = true;


        }



        //pnl Nav button clicks
        private void btnPrev_Click(object sender, EventArgs e)
        {

            switch (orderStep) //evaluates variable of orderStep and runs case statement where I am currently at I want to go back a page....for prev next
            {

                case "ordertype":
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;
                
                case "build":
                    pnlBun.Visible = false;
                    pnlBuild.Visible = true;
                    break;

                case "bun": //want to move to bun from cheese
                    pnlCheese.Visible = false; //current panel, needs to go away and move backwards
                    pnlBun.Visible = true; //needs to become visible when clicking prev button
                    break;
                
                case "cheese":
                    pnlToppings.Visible = false;
                    pnlCheese.Visible = true;
                    break;

                case "toppings": //want to move to bun from cheese
                    pnlCheese.Visible = false; //current panel, needs to go away and move backwards
                    pnlToppings.Visible = true; //needs to become visible when clicking prev button
                    break;

                case "sauce":
                    pnlToppings.Visible = false; //current panel, needs to go away and move backwards
                    pnlSauce.Visible = true; //needs to become visible when clicking prev button
                    break;



                default:
                    pnlStart.Visible = true;
                    break;
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {

                case "build":

                pnlBuild.Visible = false; //want to move to next panel, needs to go away

                pnlBun.Visible = true; //next panel moving to ...want to make visible
                break;

                case "bun":

                pnlBun.Visible = false;//pnl you are on
                pnlCheese.Visible = true;//pnl you are moving to
                break;

                case "cheese":
                pnlCheese.Visible = false;//pnl you are on
                pnlToppings.Visible = true;//pnly you are moving to
                break;

                case "toppings":
                pnlToppings.Visible = false;//pnl you are on 
                pnlSauce.Visible = true;//pnl you are moving to
                break;

                case "sauce":
                pnlSauce.Visible = false;//pnl you are on
                pnlSummary.Visible = true;//pnl yo uare moving to
                break;


                default:
                pnlStart.Visible = true;

                break;

            }

        }
                
        
        
        //Build Panel
        private void btnBuildStart_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }


        //Bun panel button click start
        private void btnBun1_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "whiteBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        
        
        
        private void btnBun2_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "wheatBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        
        
        private void btnBun3_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "potatoBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;  //makes the continued button unavailable until you choose a bun type
            btnPrev.Enabled = true;
        }

        //panel cheese button click start
        
        private void btnAmerican_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "americanCheese\n";
            lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        
        
        private void btnCheddar_Click(object sender, EventArgs e)
        {

            optionsArray[1] = "cheddarCheese\n";
            lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;


        }

       
        
        private void btnSwiss_Click(object sender, EventArgs e)

        {
            optionsArray[1] = "swissCheese\n";
            lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        
        
        private void btnNoCheese_Click(object sender, EventArgs e)

        {
            optionsArray[1] = "noCheese\n";
            lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        

        }

        
        
        //Toppings Panel button click start
        private void btnPickle_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "Pickle\n";
            lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "Tomato\n";
            lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;

        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "Onion\n";
            lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "Lettuce\n";
            lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }
        //sauce panel button click start

        private void btnKetchup_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "Ketchup\n";
            lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "Mustard\n";
            lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "Mayo\n";
            lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        private void btnSpecialSauce_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "SpecialSauce\n";
            lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

      //Panel Top Nav Button Clicks
        private void btnNavBun_Click(object sender, EventArgs e)
        {
            
            pnlBun.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }

        private void btnNavCheese_Click(object sender, EventArgs e)
        {
            pnlCheese.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }

        private void btnNavToppings_Click(object sender, EventArgs e)
        {
            pnlToppings.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }

        private void btnNavSauce_Click(object sender, EventArgs e)
        {
            pnlSauce.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }







    }
}
