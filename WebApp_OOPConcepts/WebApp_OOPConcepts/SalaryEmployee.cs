using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    internal class SalaryEmployee : Employee
    {

        #region Properties
        public decimal Salary { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString() 
        {
            return $"{base.ToString()}\n\t" +
                      $"Salary....{GetValueToPay():C2}\n\t"; //El C2 significa, lo que retorne lo formate en C, currency y deje dos decimales de ser necesario
        }


    }

    } 

