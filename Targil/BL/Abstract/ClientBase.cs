using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public abstract class ClientBase
    {
        public decimal GetInterestForExtraMonthes(int Period)
        {
            if(Period> 12)
            {
                return (Period - 12) * 0.15m;
            }
            return 0;
        }

        public abstract decimal CalculateLoan(decimal amount, int period);
    }
}
