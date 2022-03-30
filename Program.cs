using System;

namespace EmployeePayrollService_Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomr to the Employee payroll service ado .net program");
            EmployeeRepo employeeRepo = new EmployeeRepo();
            employeeRepo.checkConnection();
        }
    }
}
