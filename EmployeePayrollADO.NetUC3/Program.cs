using System;

namespace EmployeePayrollADO.NetUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Payroll Service ADO.NET \n");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeId = 1;
            employee.EmployeeName = "Akhila";
            employee.PhoneNumber = 9550458288;
            employee.Address = "vidyanagar";
            employee.Department = "Sales";
            employee.Gender = 'F';
            employee.BasicPay = 10000;
            employee.Deductions = 300;
            employee.TaxablePay = 550;
            employee.Tax = 340;
            employee.NetPay = 700000;
            employee.StartDate = DateTime.Now;
            employee.City = "Karimnagar";
            employee.Country = "India";
            employee.JobDescription = "BSM";
            employee.Month = "Aug";
            employee.EmployeeSalary = 40000;
            employee.SalaryId = 4034;

            //repo.AddEmployee(employee);

            Console.WriteLine("\n Data is Stored in DataBase.");
            //Console.WriteLine("\n Data is Stored in DataBase.");

            repo.GetEmployeeDetails();
            //repo.GetEmployeeDetails();

            Console.WriteLine("Your Data is Executed");
            //Console.WriteLine("Your Data is Executed");

            Salary salary = new Salary();

            employee.EmployeeSalary = 50000;
            employee.SalaryId = 9024;
            employee.EmployeeId = 9;
            employee.Month = "Jan";

            salary.UpdateEmployeeSalary(employee);
        }

    }
}
