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
         
            new Employees("Abraham", Employees.PostList.Controller, 1000.00M, 1300.00M);

            EmployeesCollection<Employees>.ShowList();
        }
    }
}