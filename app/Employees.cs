using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace app
{
    public class Employees
    {
        public enum PostList 
        {
            DepartmentHead,
            DepartmentManager,
            SalesManager,
            Specialist,
            B2BSpecialist,
            Merchandiser,
            AdministratorRM,
            AdministratorEM,
            OperatorWarehouse,
            Director,
            Controller,
            SecurityHead,
            SecuritySpecialist
        }
        public string Name { get; set; }
        public PostList Post { get; set; }
        public decimal Salary { get; set; }
        public decimal Gain { get; set; }
        public string Department { get; set; }

        public Employees(string name, PostList post, decimal salary, decimal gain)
        {
            Name = name;
            Post = post;
            Salary = salary;
            Gain = gain;
        }
       

       


    }
}
