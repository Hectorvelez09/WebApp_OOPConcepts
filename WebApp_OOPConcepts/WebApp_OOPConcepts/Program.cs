using System;

namespace WebApp_OOPConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("<------------------------->");
                Console.WriteLine("<-- MY FIRST DATE CLASS -->");
                Console.WriteLine("<------------------------->");
                Console.WriteLine("");

                Console.Write("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                

                Console.Write("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());

                var dateObject = new Date(year, month, day);
                Console.WriteLine("\nThe day entered is: " + dateObject);

                Employee SalaryEmployee = new SalaryEmployee() 
                { 
                Id = 1,
                FirsName = "Patricia",
                LastName = "Alvarez",
                BirthtDate = dateObject,
                HiringDate = dateObject,
                IsActive = true,
                Salary = 1160000
                };  //Instanciando

                Console.WriteLine(SalaryEmployee);


            }
            catch (Exception message)
            {
                    Console.WriteLine(message);
              
            }

            
        }
    }
}
