using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyBill_KyleHinton
{
    //static classes for reading and saving data to and from a text file.
    class CustomerClassData
    {
        //string for the name of a text files
        const string path = "Customers.txt";

        //This function will read from the Customer.txt and it will write them to a list
        //This function returns a list of customers
        public static List<Customer> ReadCustomers()
        {
            //variable declarations.
            List<Customer> customers = new List<Customer>();        //List of customers
            FileStream fs = null;               //Pointer to the file
            StreamReader sr = null;             //Pointer to he file

            string aline;                   //string for a line from a file
            string[] data;                  //array of sections from that string
            Residential ResCustomer;        //Residential customer
            Industrial IndCustomer;         //Industrial Customer
            Commercial CommCustomer;         //Commercial customer
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read); //Open the file stream and set access to read
                sr = new StreamReader(fs);          //Set the stream reader pointer to the same as the filestream.

                while (!sr.EndOfStream)
                {
                    aline = sr.ReadLine();          //gets a line from the text file
                    data = aline.Split('\t');       //Splits up the line wherever there is a tab
                    //Read the customer type first and branch out for different customers
                    if (data[2] == "R")     //Make a residential customer if the type is R
                    {
                        //Create customer with the split up line
                        ResCustomer = new Residential(data[0], Convert.ToInt32(data[1]), data[2], Convert.ToDecimal(data[3]));
                        customers.Add(ResCustomer);     //Add customer to the list.
                    }
                    //Do the same for the other types.
                    if (data[2] == "C")     //Make commercial customer if type is c
                    {
                        //Create customer with the split up line
                        CommCustomer = new Commercial(data[0], Convert.ToInt32(data[1]), data[2], Convert.ToDecimal(data[3]));
                        customers.Add(CommCustomer); //Add customer to the list.
                    }
                    if (data[2] == "I")
                    {
                        //Create customer with the split up line
                        IndCustomer = new Industrial(data[0], Convert.ToInt32(data[1]), data[2], Convert.ToDecimal(data[3]));
                        customers.Add(IndCustomer); //Add customer to the list.
                    }

                }

            }

            catch (Exception ex)    //Exception handling when there is no file, for example
            {
                throw ex;
            }
            finally                 //Close the application after the exception is thrown.
            {
                if (sr != null) sr.Close();
            }
            return customers;  // returns a list of Customers

         }


        //This function will go through a list of customers and save them to aline on a text file.
        public static void SaveCustomers(List<Customer> customers)
        {
            FileStream fs = null;       //Instantiate a new Filestream reader to point at the file.
            StreamWriter sw = null;     //Instantiate a new stream writer for writing to file
            try
            {
                //fs is in write mode
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);   //Declaration for filestream reader. Path is the variable for text file name.
                sw = new StreamWriter(fs);

                foreach (Customer cust in customers) //For all customers in the list, including the new ones
                    sw.WriteLine(cust.LineToFile());    //Write a new line on the file.
            }
            catch (Exception ex) //Catch exception
            {
                throw ex;       //Throw error message but there is no message right now
            }
            finally             //Close the program after error message
            {
                if (sw != null) sw.Close(); //close after the excepion is thrown.
            }
        }
    }
}
