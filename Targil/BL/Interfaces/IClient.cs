﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public  interface IClient
    {
        decimal  CalculateLoan(decimal amount, int period);
    }
}
