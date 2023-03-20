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

      
              

                Employee SalaryEmployee = new SalaryEmployee() 
                { 
                Id = 100,
                FirsName = "Patricia",
                LastName = "Alvarez",
                BirthtDate = new Date(year, month, day),
                HiringDate = new Date(year, month, day),
                IsActive = true,
                Salary = 1160000
                };  //Instanciando

                Console.WriteLine(SalaryEmployee);
                Console.WriteLine();

                Employee CommisssionEmployee = new CommissionEmployee()
                {
                    Id = 200,
                    FirsName = "Julio",
                    LastName = "Perez",
                    BirthtDate = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = false,
                    CommissionPercentage = 5,   
                    Sales = 20000000
                };  //Instanciando

                Console.WriteLine(CommisssionEmployee);

                Console.Write("\n\nPlease type the ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please the first name: ");
                String firsName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Please the last name: ");
                String lastName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Please type the if is active: ");
                bool isActive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please type the value of the hour: ");
                float hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please type value per hour: ");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();



                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    FirsName = firsName,
                    LastName = lastName,
                    BirthtDate = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue
                };  //Instanciando

                Console.WriteLine(hourlyEmployee);


                Employee baseCommissionEmployee = new BaseCommissionEmployee()
                {
                    Id = 400,
                    FirsName = "Armando",
                    LastName = "Tirado",
                    BirthtDate = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = true,
                    CommissionPercentage = 10,
                    Sales = 30000000,
                    Base = 5000000
                };  //Instanciando

                Console.WriteLine(baseCommissionEmployee);

                Invoice invoice = new Invoice()
                {
                    Id = 5050,
                    Description = "200 de cilantro",
                    Quantity = 100,
                    Price = 200
                };
                Console.WriteLine(invoice);
            }
            catch (Exception message)
            {
                    Console.WriteLine(message);
              
            }

            
        }
    }
}
