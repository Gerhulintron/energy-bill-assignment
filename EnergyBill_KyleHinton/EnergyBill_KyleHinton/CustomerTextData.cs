using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyBill_KyleHinton
{
    class CustomerTextData
    {

        const string path = "Customers.txt";
        const int MAX_SIZE = 100;
        string[] names = new string[MAX_SIZE];
        int[] number = new int[MAX_SIZE];
        string[] type = new string[MAX_SIZE];
        decimal[] charge = new decimal[MAX_SIZE];
        int numCustomers = 0;

        private void ReadCustomers2()
        {
            FileStream fs = null;
            StreamReader sr = null;
            string aline;
            string[] dataPart;
            try
            {
                //reading from a textfile Customer.txt with a variable called path
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    aline = sr.ReadLine();
                    dataPart = aline.Split('\t');


                    //What are the actual PARTS of my text data that is getting read.
                    names[numCustomers] = dataPart[0];
                    number[numCustomers] = Convert.ToInt32(dataPart[1]);
                    type[numCustomers] = Convert.ToString(dataPart[2]);
                    charge[numCustomers] = Convert.ToDecimal(dataPart[3]);
                    numCustomers++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while reading data: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        private void SaveProducts2()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            String aline;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                for(int i = 0; i < numCustomers; i++)
                {
                    aline = names[i] + "\t" + number[i].ToString() + "\t" + type[i] + "\t" + charge[i].ToString();
                    sw.WriteLine(aline);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while writing data: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }

    }
}
