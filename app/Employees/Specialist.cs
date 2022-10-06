using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Employees
{
    public class Specialist : Employees
    {
        public Specialist(string name, PostList post, decimal salary, decimal gain) : base(name, post, salary, gain)
        {
        }
    }
}
