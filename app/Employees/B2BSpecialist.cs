using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Employees
{
    public class B2BSpecialist : Employees
    {
        public B2BSpecialist(string name, PostList post, decimal salary, decimal gain) : base(name, post, salary, gain)
        {
        }
    }
}
