using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyBill_KyleHinton
{
    class Commercial : Customer
    {

        //Static variables
        public static int commercialCount;          //The Number of commercial customers
        public static decimal commercialTotal;      //The total amount of dollars from all commercial customers


        //Constructor for Commercial Customer Class
        //4 fields of input(string, int, string, decimal)
        public Commercial (string CustomerName, int AccountNo, string CustomerType, decimal ChargeAmount)
        {
            this.AccountNo = AccountNo;              
            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.ChargeAmount = ChargeAmount;
            commercialCount++;                                  //Increments the static variable, for commercial customer
            commercialTotal = commercialTotal + ChargeAmount;   //Adds to the total dollar amount, when a new customer record is made.
        }

        //Function that returns the number of commercial customers as an int
        public int getCommercialCount()
        {
            return commercialCount;
        }

        //Calculates the Commercial electric bill.
        //Input a decimal number for the hours
        //Returns a decimal output for the dollars charged
        public static decimal CommercialCalculate(decimal hours)
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


        //Method override
        public override decimal CommercialCalculate()
        {
            throw new NotImplementedException();
        }
        //Method override
        public override decimal IndustrialCalculate()
        {
            throw new NotImplementedException();
        }
        //Method override
        public override decimal ResidentialCalculate()
        {
            throw new NotImplementedException();
        }

        //input the Commercial type of customer. Returns customer deails as a string.
        public string toString(Commercial commercialCustomer)
        {
            string commercialString = "Account Number: " + commercialCustomer.AccountNo + " \n" +
                                       "Customer Name: " + commercialCustomer.CustomerName + " \n" +
                                       "Type of Account: " + commercialCustomer.CustomerType + " \n" +
                                       "Charge Amount: " + commercialCustomer.ChargeAmount + " \n";
            return commercialString;
        }

    }
}
