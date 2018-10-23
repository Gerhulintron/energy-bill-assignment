using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyBill_KyleHinton
{
    class Industrial : Customer
    {
        //static variables
        public static int industrialCount;
        public static decimal industrialTotal;

        //Constructor for Industrial Customer Class
        //4 fields of input(string, int, string, decimal)
        public Industrial(string CustomerName, int AccountNo, string CustomerType, decimal ChargeAmount)
        {
            this.AccountNo = AccountNo;
            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.ChargeAmount = ChargeAmount;
            industrialCount++;                                  //increments the number of customers
            industrialTotal = industrialTotal + ChargeAmount;   //Adds the new charge amount to the industrial charge amount

        }

        //Returns the number of industrial customers
        public int getIndustrialCount()
        {
            return industrialCount;
        }

        //Function for calculating the charge amount for the industrial bill.
        //Input the decimal hours and off hours
        //Returns a decimal for the current industrial charge amount.
        public static decimal IndustrialCalculate(decimal peak_hours, decimal off_peak_hours)
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

        //Input the Industrial Customer instance.
        //Returns a string about that customer's data.
        public string toString(Industrial industrialCustomer)
        {
        string industrialString = "Account Number: " + industrialCustomer.AccountNo + " \n" +
                                   "Customer Name: " + industrialCustomer.CustomerName + " \n" +
                                   "Type of Account: " + industrialCustomer.CustomerType + " \n" +
                                   "Charge Amount: " + industrialCustomer.ChargeAmount + " \n";
           return industrialString;
        }


        //Method overrride
        public override decimal IndustrialCalculate()
        {
            throw new NotImplementedException();
        }
        //Method overrride
        public override decimal CommercialCalculate()
        {
            throw new NotImplementedException();
        }
        //Method overrride
        public override decimal ResidentialCalculate()
        {
            throw new NotImplementedException();
        }
    }
}
