﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Employees
{
    public class AdministratorEM : Employees
    {
        public AdministratorEM(string name, PostList post, decimal salary, decimal gain) : base(name, post, salary, gain)
        {
        }
    }
}
