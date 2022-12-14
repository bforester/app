using System;

namespace app.Department
{
    public class EM<T> : Department<T>
    {
        public override string NameOfDepartment
        {
            get { return NameOfDepartment; }
            set { NameOfDepartment = "EM"; }
        }
        public override int AmountOfEmployees { get; set; }
        public override decimal Expenses { get; set; }
        public override decimal Profit { get; set; }
        public override T? Employees { get; set; }
    }
}
