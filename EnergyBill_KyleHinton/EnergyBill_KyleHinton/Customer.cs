using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyBill_KyleHinton
{


    abstract class Customer
    {


        public const decimal RESIDENTIAL_RATE = 0.052m;
        public const decimal RESIDENTIAL_BASE = 6.00m;
        public const decimal COMMERCIAL_RATE = 0.045m;
        public const decimal COMMERCIAL_BASE = 60.00m;
        public const decimal INDUSTRIAL_PK_RATE = 0.065m;
        public const decimal INDUSTRIAL_PK_BASE = 76.00m;
        public const decimal INDUSTRIAL_OPK_RATE = 0.028m;
        public const decimal INDUSTRIAL_OPK_BASE = 40.00m;
        public const decimal BASE_HOURS = 1000.00m;
        public const string RESIDENTIAL = "R";
        public const string COMMERCIAL = "C";
        public const string INDUSTRIAL = "I";

        private int accountNo;
        private string customerName;
        private string customerType;
        private decimal chargeAmount;

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerType { get => customerType; set => customerType = value; }
        public decimal ChargeAmount { get => chargeAmount; set => chargeAmount = value; }

        public abstract decimal IndustrialCalculate();
        public abstract decimal CommercialCalculate();
        public abstract decimal ResidentialCalculate();

 //       public abstract decimal CalculateBill(decimal hours);
 //       public abstract decimal CalculateBill(decimal first_num, decimal second_num);
        public string LineToFile()
        {
            return CustomerName + "\t" + AccountNo.ToString() + "\t" + CustomerType + "\t" + ChargeAmount.ToString();
        }


    }
}
