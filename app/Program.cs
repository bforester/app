using app;
using app.Department;
using app.Employees;
using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Employees abraham = new Employees("Abraham", Employees.PostList.Controller, 1000.00M, 1300.00M);
            Employees ben = new Employees("Ben", Employees.PostList.DepartmentManager, 10030.00M, 13020.00M);

            EmployeesCollection < Employees >  employees = new EmployeesCollection<Employees>(abraham);

            employees.Add(abraham);
            employees.Add(ben);

            employees.Show();

        }
    }
}