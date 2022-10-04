using System;


namespace app.Department
{
    abstract public class Department<T>
    {
        public abstract string NameOfDepartment {get; set; }
        public abstract int AmountOfEmployees {get; set; }

        public abstract decimal  Expenses { get; set; }
        public abstract decimal Profit { get; set; }
        public decimal Investment { get; set; }

        public abstract T? Employees { get; set; }
    }
}
