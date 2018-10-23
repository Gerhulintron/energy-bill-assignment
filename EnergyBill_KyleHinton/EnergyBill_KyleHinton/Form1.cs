using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyBill_KyleHinton
{

    //Author Kyle Hinton
    //June 14 2018
    //This program is for calculating an energy bill for various customer types.
    public partial class EnergyBill : Form
    {
        const decimal RESIDENTIAL_RATE = 0.052m;
        const decimal RESIDENTIAL_BASE = 6.00m;
        const decimal COMMERCIAL_RATE = 0.045m;
        const decimal COMMERCIAL_BASE = 60.00m;
        const decimal INDUSTRIAL_PK_RATE = 0.065m;
        const decimal INDUSTRIAL_PK_BASE = 76.00m;
        const decimal INDUSTRIAL_OPK_RATE = 0.028m;
        const decimal INDUSTRIAL_OPK_BASE = 40.00m;
        const decimal BASE_HOURS = 1000.00m;
        const string RESIDENTIAL = "R";
        const string COMMERCIAL = "C";
        const string INDUSTRIAL = "I";
        public decimal resTotal = 0.00m;
        public decimal indTotal = 0.00m;
        public decimal commTotal = 0.00m;
        public decimal customerTotal = 0.00m;
 //       public int numOfCustomers = 0;

        

        //This function is for changing the visibility of a Group Box when a Radio Button is checked.
        //It takes a radio button and a GrouBox as parameters
        //It is void and so it does not return anything.
        public void viewChanger(RadioButton radButton, GroupBox grpBox)
        {
            if (radButton.Checked == true)      //If the radio button is checked
            {
                grpBox.BringToFront();          //Bring the groupbox to the front on z-indez
                grpBox.Visible = true;          //Set visibility of GroupBox to be true
            }
            else
            {
                grpBox.Visible = false;         //Set visibility of Group Box to False.
            }
        }

        //Takes a textbox an an input
        //This will return false if there is no data in a TextBox
        //This function will return true if there is data in the TextBox
        public bool emptyCheck(TextBox input)
        {
            bool check;                         //variable declaration
            if(input.Text == "")                //check for empty strings
            {
                MessageBox.Show("You must enter data into the text box.");  //show a message box to warn user
                check = false;                  //value assigned.
                input.Focus();
            }
            else
            {
                check = true;                   //value true assigned if there is data in the box.
            }
            return check;                       //return the value of check
        }

        //This function checks to see if a number is less than 0.
        //Takes a textbox for a parameter
        //Returns true if the number in the textbox is greater than 0
        //Returns false if the number is less than 0.
        public bool negativeCheck(TextBox input)
        {
            bool check;
            if(Convert.ToDecimal(input.Text) < 0) //check the value in the text box.
            {
                //if it's less than 0, then a message will appear and check will be false.
                MessageBox.Show("You must enter a number greater or equal to zero in box.");
                check = false;
                input.Focus();
            } else
            {
                check = true; //check is true if the number is greater than zero.
            }
            return check;   //return the value of check.
        }

        //This function will check if a the input data is a whole number.
        //This function takes a textbox as a parameter.
        //Returns false if the data can't be turned into an integer.
        //Returns true when the input is turned into an integer.
        public bool wholeCheck(TextBox input)
        {
            bool check;             //declaration.
            int number;             //declaration
            if(!Int32.TryParse(input.Text, out number)) //if the input is NOT a whole number.
            {
                check = false;      //then the return value of check is false 
                MessageBox.Show("Please enter a whole number, without decimals.");
                input.Focus();
            }
            else
            {
                check = true;       //if it is a whole number, then check is true.
            }
            return check;           //return the value of check.
        }
        /*
        //simple multiplication functions
        //returns the product
        //takes two decimals as parameters
        public decimal multiplier(decimal first_num, decimal second_num)
        {
            return (first_num * second_num);
        }

        //this will calculate the bill for commercial energy rates.
        //this function takes a decimal which represents the hours
        //this function will return the total of the bill amount.

        public decimal commercialMultiply(decimal hours)
        {
            if (hours > BASE_HOURS)                                         //if there are more than 1000 hours.
            {
                decimal charged_hours = hours - BASE_HOURS;                 //subtract 1000 hours.
                return (charged_hours * COMMERCIAL_RATE) + COMMERCIAL_BASE; //multiply the remaining hours and return the Billing amount.
            }
            else
            {
                return COMMERCIAL_BASE;                                     //return the commercial base if less than 1000 hours are used.
            }
        }

        //the following function will calculate the energy bill for an industrial subscription.
        //this function takes two decimals as parameters, the peak_kwh and off_peak_kwh
        //this function will return the total of the bill
        public decimal industrialCalculate(decimal peak_hours, decimal off_peak_hours)
        {
            decimal peak_total;
            decimal off_peak_total;
         //   decimal peak_hours = Convert.ToDecimal(txtPeakHours.Text);

            //calculate the charge for KWH at peak hours.
            if (peak_hours > BASE_HOURS)
            {
                decimal charged_peakHRS = peak_hours - BASE_HOURS;
                peak_total = (charged_peakHRS * INDUSTRIAL_PK_RATE) + INDUSTRIAL_PK_BASE;
            }
            else
            {
                peak_total = INDUSTRIAL_PK_BASE;
            }


            //    decimal off_hours = Convert.ToDecimal(txtOffPeakHours.Text);

            //calculate the charge for the KWH on off peak hours.
            if (off_peak_hours > BASE_HOURS)
            {
                decimal charged_peakHRS = off_peak_hours - BASE_HOURS;
                off_peak_total = (charged_peakHRS * INDUSTRIAL_OPK_RATE) + INDUSTRIAL_OPK_BASE;
            }
            else
            {
                off_peak_total = INDUSTRIAL_OPK_BASE;
            }

            return peak_total + off_peak_total;                         // Return the industrial bill total
        }

*/

        public EnergyBill()
        {
            InitializeComponent();
        }



        //Residential Calculculations and Class construction.
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Validation Check
            if (emptyCheck(txtKWH_Res) && wholeCheck(txtKWH_Res) && negativeCheck(txtKWH_Res) && emptyCheck(txtCustomerName) && emptyCheck(txtAccountNumber))
            {
                decimal hours = Convert.ToDecimal(txtKWH_Res.Text);                         //get value for KWH
                decimal total = (Residential.CalculateBill(hours, RESIDENTIAL_RATE)) + RESIDENTIAL_BASE;   //get value for the bill
                string name = txtCustomerName.Text;     //get name of the customer
                string type = RESIDENTIAL;              // get the type of the customer
                int accountNum = Convert.ToInt32(txtAccountNumber.Text);        //Create the account number
                Residential residential = new Residential(name, accountNum, type, total);   //Constructor for the Residential class.

   //             resTotal = resTotal + total;
                lblResTotal.Text = Residential.residentialTotal.ToString("c");
                lblCustomerTotal.Text = "Customer Total: " + (Residential.residentialTotal + Industrial.industrialTotal + Commercial.commercialTotal).ToString("c");
                //               numOfCustomers++;
                //               lblCustNum.Text = numOfCustomers.ToString();
                //                customerTotal = customerTotal + total;
                //                lblCustomerTotal.Text = customerTotal.ToString("c");
                lblCustNum.Text = "Number of Customers: " + (Residential.residentialCount + Industrial.industrialCount + Commercial.commercialCount);
                lblResidentialCount.Text = "Residential Count: " + residential.getResidentialCount();
                lblResTotal.Text = "Residential Total: " + Residential.residentialTotal.ToString("c");
                lblResOutput.Text = total.ToString("c");                                    //output the bill as a dollar amount.
                customerList.Add(residential);



                DisplayCustomers(customerList);

            }
        }

        //Commercial button click and calculation. Creates a commercial customer object
        private void btnCalcComm_Click(object sender, EventArgs e)
        {
            //Validation Check
            if (emptyCheck(txtKWH_Comm) && wholeCheck(txtKWH_Comm) && negativeCheck(txtKWH_Comm) && emptyCheck(txtCustomerName) && emptyCheck(txtAccountNumber))
            {
                string name = txtCustomerName.Text;                             //Customer name
                int accountNum = Convert.ToInt32(txtAccountNumber.Text);        //Account Number
                string type = txtAccountNumber.Text;                            //Account Type
                decimal hours = Convert.ToDecimal(txtKWH_Comm.Text);    //get the value of the kwh
                decimal total = Commercial.CommercialCalculate(hours);              //calculate the commercial energy bill
                Commercial commercial = new Commercial(name, accountNum, COMMERCIAL, total); //Class constructor
                customerList.Add(commercial);   //Add commercial object to the liast.


                //Changes and updates the data labels
                lblCustomerTotal.Text = "Customer Total: " + (Residential.residentialTotal + Industrial.industrialTotal + Commercial.commercialTotal).ToString("c");
                lblCustNum.Text = "Number of Customers: " + (Residential.residentialCount + Industrial.industrialCount + Commercial.commercialCount);
                lblCommCount.Text = "Commercial Count: " + commercial.getCommercialCount();
                lblCommTotal.Text = "Commercial Total: " + Commercial.commercialTotal.ToString("c");

                lblCommOuput.Text = total.ToString("c");                 //output the dollar amount.
                DisplayCustomers(customerList);                         //Display the customer list
            }
        }


        //Industrial button click and calculation. Creates an industrial customer object
        private void btnCalcIndustrial_Click(object sender, EventArgs e)
        {
            //Validation Check
            if (emptyCheck(txtPeakHours) && wholeCheck(txtPeakHours) && negativeCheck(txtPeakHours) 
               && emptyCheck(txtOffPeakHours) && wholeCheck(txtOffPeakHours) && negativeCheck(txtOffPeakHours) && emptyCheck(txtCustomerName) && emptyCheck(txtAccountNumber))
            {
                string name = txtCustomerName.Text;                         //Customer name
                int accountNum = Convert.ToInt32(txtAccountNumber.Text);    //Customer account number
                string type = txtAccountNumber.Text;                        //Account type
                //Get the values for peak_KWH usage and off_peak KWH usage
                decimal peak_hours = Convert.ToDecimal(txtPeakHours.Text);  //Peak hours
                decimal off_peak_hours = Convert.ToDecimal(txtOffPeakHours.Text);           //Off peak hours
                decimal total = Industrial.IndustrialCalculate(peak_hours, off_peak_hours); //Calculate the industrial bill
                Industrial industrial = new Industrial(name, accountNum, INDUSTRIAL, total);    //Create new industrial customer class with above values
                indTotal = indTotal + total;        //add to indsutrial total

                lblIndTotal.Text = indTotal.ToString("c");      //update the total industrial customer dollars string
                customerList.Add(industrial);                   //add industrial customer to the list


                //Update the data information for the number of customers and total dollars owed
                lblCustNum.Text = "Number of Customers: " + (Residential.residentialCount + Industrial.industrialCount + Commercial.commercialCount);
                lblIndustrialCount.Text = "Industrial Count: " + industrial.getIndustrialCount();
                lblIndTotal.Text = "Industrial Total: " + Industrial.industrialTotal.ToString("c");
                lblCustomerTotal.Text = "Customer Total: " + ((Residential.residentialTotal + Industrial.industrialTotal + Commercial.commercialTotal).ToString("c"));
                //               numOfCustomers++;
                //                lblCustNum.Text = numOfCustomers.ToString();
                //              customerTotal = customerTotal + total;
                //              lblCustomerTotal.Text = customerTotal.ToString("c");

                lblIndustrialOutput.Text = total.ToString("c");                  //Output the total as a dollar amount in  a string.
                DisplayCustomers(customerList);
            }


        }

        //visibility change event for residential groupBox.
        private void radResSelect_CheckedChanged(object sender, EventArgs e)
        {
            viewChanger(radResSelect, grpResEnergyBill);

        }

        //visibility change event for commercial groupBox.
        private void radCommSelect_CheckedChanged(object sender, EventArgs e)
        {
            viewChanger(radCommSelect, grpCommEnergyBill);
        }

        //visibility change event for industrial groupBox
        private void radIndustrialSelect_CheckedChanged(object sender, EventArgs e)
        {
            viewChanger(radIndustrialSelect, grpIndustrialEnergyBill);
        }

        //exit application on click.
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //exit application on click.
        private void btnCommExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //exit application on click.
        private void btnIndExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Reset the indsutrial parameters
        private void btnResetInd_Click(object sender, EventArgs e)
        {
            txtPeakHours.Text = "";
            txtOffPeakHours.Text = "";
            lblIndustrialOutput.Text = "";
        }

        //Reset the Residential Parameters in the group box
        private void btnResetRes_Click(object sender, EventArgs e)
        {
            txtKWH_Res.Text = "";
            lblResOutput.Text = "";
        }

        //Reset the commercial group box parameters.
        private void btnResetComm_Click(object sender, EventArgs e)
        {
            txtKWH_Comm.Text = "";
            lblCommOuput.Text = "";
        }

        //Reset all the form text fields
        private void btnResetAll_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = "";
            txtCustomerName.Text = "";
            txtPeakHours.Text = "";
            txtOffPeakHours.Text = "";
            lblIndustrialOutput.Text = "";
            txtKWH_Res.Text = "";
            lblResOutput.Text = "";
            txtKWH_Comm.Text = "";
            lblCommOuput.Text = "";
        }

        //Exit when button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Instantiate the list of customers
        List<Customer> customerList = new List<Customer>();
        
        //When the bill is loaded, setup the user interface.

        private void EnergyBill_Load(object sender, EventArgs e)
        {
            customerList = CustomerClassData.ReadCustomers(); //Fills the customer list

            DisplayCustomers(customerList); //Displays the customer list

            //Load all the data for the current number of customers of each type and the total dollars owed for each type.
            lblResidentialCount.Text = "Residential Customers: " + Residential.residentialCount;    //Display the current number of residential customers
            lblIndustrialCount.Text = "Industrial Customers: " + Industrial.industrialCount;        //Display the current number of industrial customers
            lblCommCount.Text = "Commercial Customers: " + Commercial.commercialCount;              //Display the current number of commercial customers.
            lblCustNum.Text = "Number of Customers: " + (Residential.residentialCount + Industrial.industrialCount + Commercial.commercialCount);   //Display Total number of customers
            lblCustomerTotal.Text = "Customer Total: " + (Residential.residentialTotal + Industrial.industrialTotal + Commercial.commercialTotal).ToString("c");    //Display the total charged to customers.
            lblResTotal.Text = "Residential Total: " + Residential.residentialTotal.ToString("c");  //Total dollars from residential customers.
            lblIndTotal.Text = "Industrial Total: " + Industrial.industrialTotal.ToString("c");     //Total dollars from industrial customers.
            lblCommTotal.Text = "Commercial Total: " + Commercial.commercialTotal.ToString("c");    //Total dollars from commercial customers.
        }

        
        //Method to display a list in a listBox
        private void DisplayCustomers(List<Customer> customers)
        {
            lstCustomers.Items.Clear();         //clear the list box
            foreach (Customer c in customers)

                
                lstCustomers.Items.Add(c.LineToFile()); //rebuild the list.
   
        }

        //Save on exit
        private void EnergyBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerClassData.SaveCustomers(customerList);
        }

        //Button click to exit
        private void btnResExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
