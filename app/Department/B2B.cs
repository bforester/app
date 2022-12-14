using System;

namespace app.Department
{
    internal class B2B<T> : Department<T>
    {
        public override string NameOfDepartment 
        {
            get { return NameOfDepartment; }
            set { NameOfDepartment = "B2B"; }
        }
        public override int AmountOfEmployees { get; set; }
        public override decimal Expenses { get; set; }
        public override decimal Profit { get; set; }

        public override T? Employees  { get; set; }    
    }
}
