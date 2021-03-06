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
        bool sumNo;
        //string bunType = "";
        string orderStep; //keeps track of current pannel
       // bool navSauce;
        //bool navTopping;
        //bool navCheese;
        //bool navBun;


        
        string [] toppings = new string[] {};
        string [] sauce = new string[] {};
        public string [] optionsArray = new string [5];
        


        public Ordering()
        {
            InitializeComponent();
        }
        //Application Load Event

        private void Form1_Load(object sender, EventArgs e) //default setting of all things you change programmatically 
        {

            pnlStart.Visible = true;
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
            btnNavBun.Enabled = true;
            btnNavCheese.Enabled = true;
            btnNavToppings.Enabled = true;
            btnNavSauce.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            

            lblStack.Text = "";



        }

        //Panel Visible Changed Events //panel is object changes from load event true

        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderStep = "start";
            }
            btnNavBun.Enabled = false;
            btnNavCheese.Enabled = false;
            btnNavToppings.Enabled = false;
            btnNavSauce.Enabled = false;
            btnPrev.Enabled = false;
        }


        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderStep = "location";
            }
            btnNavBun.Enabled = false;
            btnNavCheese.Enabled = false;
            btnNavToppings.Enabled = false;
            btnNavSauce.Enabled = false;
           

        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e) //tells program what pannel it is on so we know our location in the application
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "ordertype";
            }
            btnNavBun.Enabled = true;
            btnNavCheese.Enabled = true;
            btnNavToppings.Enabled = true;
            btnNavSauce.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Visible = true;
            btnSpecialty.Enabled = true;

        }
        private void pnlSpecialty_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSpecialty.Visible == true)
            {
                orderStep = "specialty";
                btnNext.Enabled = false; //must select type before moving on
                btnPrev.Enabled = true;
                btnNext.Visible = true;
                btnNavBun.Enabled = true;
                btnNavCheese.Enabled = true;
                btnNavToppings.Enabled = true;
                btnNavSauce.Enabled = true;
                pnlStack.Visible = true;

            }

        }
    
        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {

            if (pnlBuild.Visible == true)
            {
                orderStep = "build";
                
            }

            //btnNext.Visible = true;
            //btnPrev.Enabled = true;
            btnNavBun.Enabled = true;
            btnNavCheese.Enabled = true;
            btnNavToppings.Enabled = true;
            btnNavSauce.Enabled = true;

            
        }


        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            {
                orderStep = "bun";

                if (optionsArray[0] == "") //if array position 0 is equal to an empty array do parenthesis
                {
                    btnNext.Enabled = false; //button is there but you can't click on it
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true; //continue button will be enabled
                    NavEnabled();
                    
                    
                }
            }
        }

        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {

            if (pnlCheese.Visible == true)
            {
                orderStep = "cheese";
               
                if (optionsArray[1] == "")
                {
                    btnNext.Enabled = false; //must select type before moving on
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    NavEnabled();
                    
                }
                 
            }
        }

        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible == true)
            {
                orderStep = "toppings";
                
                if (optionsArray[2] == "")
                {
                    btnNext.Enabled = false; //must select type before moving on
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    NavEnabled();
                }

            }
        }

        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {

            if (pnlSauce.Visible == true)
            {
                orderStep = "sauce";

                if (optionsArray[3] == "")
                {
                    btnNext.Enabled = false; //must select type before moving on
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    NavEnabled();
                }

            }
        }

        public void NavEnabled() //btn enabled instructions used on panels to indicate when nav should work
        {
            btnNavBun.Enabled = true;
            btnNavCheese.Enabled = true;
            btnNavToppings.Enabled = true;
            btnNavSauce.Enabled = true;
        }
        

        private void pnlSummary_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSummary.Visible == true)
            {
                orderStep = "Summary";
            }
         
            NavEnabled();
            btnPrev.Enabled = true;
            btnNext.Visible = true;
            pnlStack.Visible = false;
        }

        private void pnlComplete_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlComplete.Visible == true)
            {
                orderStep = "Complete";
            }
           
            NavEnabled();
            btnPrev.Enabled = true;
            btnNext.Enabled = false;
           
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
            lblDineLocation.Text = "Dine In";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;     
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            lblDineLocation.Text = "Take Out";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;    
        }

        //pnl 3 Build panel button clicks
        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPreviousNext.Visible = true;
        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlSpecialty.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPreviousNext.Visible = true;


        }

        //pnl Prev Next button clicks
        private void btnPrev_Click(object sender, EventArgs e)
        {

            switch (orderStep) //evaluates variable of orderStep and runs case statement where I am currently at I want to go back a page....for prev next
            {

                case "location":
                    pnlStart.Visible = true;//on button click move to panel previous to location panel
                    pnlLocation.Visible = false;//on button click make current panel go away
                    break;
                    
                case "ordertype":
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;

                case "specialty":
                    pnlSpecialty.Visible = false;
                    pnlOrderType.Visible = true;
                    break;
                
                case "build":
                    pnlOrderType.Visible = true;
                    pnlBuild.Visible = false;
                    break;

                case "bun": 
                    pnlBuild.Visible = true; //on button click move to panel previous to bun panel
                    pnlBun.Visible = false; //on button click make current panel go away
                    break;
                
                case "cheese":
                    pnlBun.Visible = true;
                    pnlCheese.Visible = false;
                    break;

                case "toppings": //want to move to bun from cheese
                    pnlCheese.Visible = true; 
                    pnlToppings.Visible = false;
                    break;

                case "sauce":
                    pnlToppings.Visible = true; //current panel, needs to go away and move backwards
                    pnlSauce.Visible = false; //needs to become visible when clicking prev button
                    break;
                case "summary":
                    pnlSauce.Visible = true;
                    pnlSummary.Visible = false;
                    break;
                case "complete":
                    pnlComplete.Visible = false;
                    pnlSummary.Visible = true;
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
                case "location":
                    pnlOrderType.Visible = true;
                    pnlLocation.Visible = false;
                    break;
                case "orderType":
                    pnlBuild.Visible = true;
                    pnlOrderType.Visible = false;
                    break;
                case "build":
                    pnlBuild.Visible = false; //pnl you are on
                    pnlBun.Visible = true; //next panel moving to ...want to make visible
                    break;
                case "specialty":
                    pnlSpecialty.Visible = false;
                    pnlSummary.Visible = true;
                    break;
                case "bun":
                //MessageBox.Show("Test");
                    pnlBun.Visible = false;//pnl you are on
                    btnNext.Enabled = false;
                    pnlCheese.Visible = true;//pnl you are moving to
                    break;

                case "cheese":
                    pnlCheese.Visible = false;
                    pnlToppings.Visible = true;
                //btnPrev.Visible = true;
                    break;

                case "toppings":
                    pnlToppings.Visible = false;
                    pnlSauce.Visible = true;
                    break;

                case "sauce":
                    pnlSauce.Visible = false;
                    pnlSummary.Visible = true;
                    break;
                
                case "summary":
                    pnlSummary.Visible = false;
                    pnlComplete.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;

            }

        }
        
        //Build Panel Button
        private void btnBuildStart_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;   
        }


        //Bun panel button click start
        private void btnBun1_Click(object sender, EventArgs e) //white bun
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string bunType = Bun.createBun("White Bun\n");
            optionsArray[0] = bunType;
            lblStack.Text = optionsArray[0];//populating label stack on stack panel from options array
            lblStackSum.Text = optionsArray[0];//setting lable stack on summary page

        }

        private void btnBun2_Click(object sender, EventArgs e) //wheat bun
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string bunType = Bun.createBun("Wheat Bun\n");
            optionsArray[0] = bunType;
            lblStack.Text = optionsArray[0];//populating label stack on stack panel from options array
            lblStackSum.Text = optionsArray[0];//setting lable stack on summary page
        }

        private void btnBun3_Click(object sender, EventArgs e) //potato bun
        {
            btnNext.Enabled = true;  //makes the continued button unavailable until you choose a bun type
            btnPrev.Enabled = true;
            string bunType = Bun.createBun("Potato Bun\n");
            optionsArray[0] = bunType;
            lblStack.Text = optionsArray[0];//populating label stack on stack panel from options array
            lblStackSum.Text = optionsArray[0];//setting lable stack on summary page
        }
    
       //panel cheese button click start
        
        private void btnAmerican_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string cheeseType = Cheese.createCheese("American\n");
            optionsArray[1] = cheeseType;
            lblStack.Text += optionsArray[1];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[1];//setting label stack on summary page
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string cheeseType = Cheese.createCheese("Cheddar\n");
            optionsArray[1] = cheeseType;
            lblStack.Text += optionsArray[1];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[1];//setting lable stack on summary page
        }
        private void btnSwiss_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string cheeseType = Cheese.createCheese("Swiss\n");
            optionsArray[1] = cheeseType;
            lblStack.Text += optionsArray[1];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[1];//setting lable stack on summary page
        }

        private void btnNoCheese_Click(object sender, EventArgs e)

        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string cheeseType = Cheese.createCheese("NoCheese\n");
            optionsArray[1] = cheeseType;
            lblStack.Text += optionsArray[1];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[1];//setting lable stack on summary page
        }

         //Toppings Panel button click start
        private void btnPickle_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string ToppingType = Toppings.createToppings("Pickles\n");
            optionsArray[2] = ToppingType;
            lblStack.Text += optionsArray[2];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[2];//setting lable stack on summary page
        }
        private void btnTomato_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string ToppingType = Toppings.createToppings("Tomato\n");
            optionsArray[2] = ToppingType;
            lblStack.Text += optionsArray[2];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[2];//setting lable stack on summary page
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string ToppingType = Toppings.createToppings("Onion\n");
            optionsArray[2] = ToppingType;
            lblStack.Text += optionsArray[2];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[2];//setting lable stack on summary page
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string ToppingType = Toppings.createToppings("Lettuce\n");
            optionsArray[2] = ToppingType;
            lblStack.Text += optionsArray[2];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[2];//setting lable stack on summary page
        }

        //sauce panel button click start

        private void btnKetchup_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string SauceType = Sauce.createSauce("Ketchup\n");
            optionsArray[3] = SauceType;
            lblStack.Text += optionsArray[3];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[3];//setting lable stack on summary page
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string SauceType = Sauce.createSauce("Mustard\n");
            optionsArray[3] = SauceType;
            lblStack.Text += optionsArray[3];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[3];//setting lable stack on summary page
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string SauceType = Sauce.createSauce("Mayo\n");
            optionsArray[3] = SauceType;
            lblStack.Text += optionsArray[3];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[3];//setting lable stack on summary page
        }

        private void btnSpecialSauce_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            string SauceType = Sauce.createSauce("Special Sauce\n");
            optionsArray[3] = SauceType;
            lblStack.Text += optionsArray[3];//populating label stack on stack panel from options array
            lblStackSum.Text += optionsArray[3];//setting lable stack on summary page
            
        }

        //Specialty Button Clicks

        private void btnSpec1_Click(object sender, EventArgs e) //Big Mac
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            optionsArray[4] = "Big Mac\n";
            lblStack.Text = optionsArray[4];//populating label stack on stack panel from options array
            lblStackSum.Text = optionsArray[4];//setting label stack on summary page
        }

        private void btnSpec2_Click(object sender, EventArgs e) //Royal with Cheese
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            optionsArray[4] = "Royal With\n Cheese\n";
            lblStack.Text = optionsArray[4];//populating label stack on stack panel from options array
            lblStackSum.Text = optionsArray[4];//setting label stack on summary page
        }

 

      //Panel Top Nav Button Clicks
        private void btnNavBun_Click(object sender, EventArgs e)
        {
            pnlBun.Visible = true; //make panel you want to see visible upon button click
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            NavVisible();
    
        }
       

        private void btnNavCheese_Click(object sender, EventArgs e)
        {
            pnlBun.Visible = false;
            pnlCheese.Visible = true; //make panel you want to see visible upon button click
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            NavVisible();
        }

        private void btnNavToppings_Click(object sender, EventArgs e)
        {
          
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true; //make panel you want to see visible upon button click
            pnlSauce.Visible = false;
            NavVisible();
        
        }

        private void btnNavSauce_Click(object sender, EventArgs e)
        {
           
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true; //make panel you want to see visible upon button click
            NavVisible();

        }

        public void NavVisible() //load instructions for unchanging panels used in navagation clicking
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPreviousNext.Visible = true;
            pnlBuild.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }

        private void btnSumYes_Click(object sender, EventArgs e)
        {
            sumNo = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            

        }

        private void btnSumNo_Click(object sender, EventArgs e)
        {
            sumNo = true;
            pnlSummary.Visible = false;
            pnlStart.Visible = true;
            pnlPreviousNext.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            lblStack.Text = optionsArray[4] = "";
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            btnComplete.Enabled = true;
            lblStack.Text = optionsArray[4] = "";
            pnlStart.Visible = true;
            pnlComplete.Visible = false;

        }
    }
}
