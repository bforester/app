using app;
using app.Department;
using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;


            List<Employees> list = new List<Employees>(); 


            Employees employees1 = new Employees("Abraham", Employees.PostList.Controller, 1000.00M, 1300.00M);
            Employees employees2 = new Employees("Den", Employees.PostList.Controller, 1000.00M, 1300.00M);

            list.Add(employees2);
            list.Add(employees1);

            foreach (var employee in list)
            {
                i++;
                Console.WriteLine($"Employee{i}\nName : {employee.Name}\nPost: { employee.Post }\nSalary : {employee.Salary}\nGain: {employee.Gain}\n  ");    
            }
        }
    }
}