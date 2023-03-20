using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    internal class HourlyEmployee : Employee
    {

        #region Properties
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

      

        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)Hours;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                      $"Hours..............{Hours:C2}\n\t" +
                     $"value per hour......{HourValue:C2}\n\t"+
                     $"Get value to pay....{GetValueToPay():C2}\n\t";


        }
        #endregion
    }
}