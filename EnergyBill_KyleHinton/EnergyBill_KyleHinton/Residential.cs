using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyBill_KyleHinton
{

    
    class Residential : Customer
    {
        //static variables
        public static int residentialCount;     //number of residential customers
        public static decimal residentialTotal; //total dollars from residential customers

        //Constructor for Residential Customer Class
        //4 fields of input(string, int, string, decimal)
        public Residential(string CustomerName, int AccountNo, string CustomerType, decimal ChargeAmount)
        {
            this.AccountNo = AccountNo;
            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.ChargeAmount = ChargeAmount;
            residentialCount++;                                     //Increments the number of residential customers when a residentidal customer is constructed
            residentialTotal = residentialTotal + ChargeAmount;     //Adds the current charge amount to the total charge amount.
        }

        //returns the number of residential customers
        public int getResidentialCount()
        {
            return residentialCount;
        }

        //Function for calculating the current residential charges.
        //Input two numbers
        //Returns the poduct of the two numbers.
        public static decimal CalculateBill(decimal first_num, decimal second_num)
        {
            return (first_num * second_num);
        }


        //Creates a string for the data for a residential customer.
        //Input a residential customer
        //Returns a string of a customer's data
        public string toString(Residential residentialCustomer)
        {
            string residentialString = "Account Number: " + residentialCustomer.AccountNo + " \n" +
                                       "Customer Name: " + residentialCustomer.CustomerName + " \n" +
                                       "Type of Account: " + residentialCustomer.CustomerType + " \n" +
                                       "Charge Amount: " + residentialCustomer.ChargeAmount + " \n";
            return residentialString;
        }


        //method overide
        public override decimal IndustrialCalculate()
        {
            throw new NotImplementedException();
        }

        //method overide
        public override decimal CommercialCalculate()
        {
            throw new NotImplementedException();
        }

        //method overide
        public override decimal ResidentialCalculate()
        {
            throw new NotImplementedException();
        }
    }
}
