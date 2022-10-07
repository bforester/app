using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class EmployeesCollection<T>
    {
        int count;
        T[] arrayEmployees = new T[10];


        public EmployeesCollection()
        { 
        
        }

        public EmployeesCollection(T employ)
        {
            if (count == 0)
            {
                arrayEmployees[0] = employ;
            }
            else if (arrayEmployees.Length < count)
            {
                arrayEmployees[count] = employ;             
            }
            else if (arrayEmployees.Length == count)
            {
                ResizeArrayEmployees();
            }
            count++;
        }


        public void Add(T employ)
        {
            if (count == 0)
            {
                arrayEmployees[0] = employ;
            }
            else if (arrayEmployees.Length < count)
            {
                arrayEmployees[count] = employ;
            }
            else if (arrayEmployees.Length == count)
            {
                ResizeArrayEmployees();
            }
            count++;
        }


        public void Show()
        {
            Console.WriteLine(count);
        }

        void ResizeArrayEmployees()
        {
            Console.WriteLine("Resize");
        }





    }
}
