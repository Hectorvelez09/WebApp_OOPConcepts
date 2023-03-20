using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    internal class CommissionEmployee : Employee
    {

        #region Properties
        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }
     
        public decimal Salary { get; set; }

       

   
        public override decimal GetValueToPay()
        {
            return Sales * ((decimal)(CommissionPercentage/100)); //Casteo porque no son los mismos tipos de datos
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
            $"Commission Percentage...{CommissionPercentage/100:P2}\n\t" +
            $"Sales.................{Sales:C2}\n\t" +
            $"Ge tValue To Pay.................{GetValueToPay():C2}";


        }
        #endregion

    }
}