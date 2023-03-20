using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public abstract class Employee
    {
        #region Properties

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public Date BirthtDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"\n\n<---- E M P L O Y E ---->\n\t" +
                   $"ID............{Id}\n\t" +
                   $"Firs Name.....{FirsName}\n\t" +
                   $"Last Name.....{LastName}\n\t" +
                   $"Birtht Date...{BirthtDate}\n\t" +
                   $"Hiring Date...{HiringDate}\n\t" +
                   $"Is Active?....{IsActive}\n\t" ;
        }


        #endregion
    }
}
