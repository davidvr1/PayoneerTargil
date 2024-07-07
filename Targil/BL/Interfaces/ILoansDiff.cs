using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ILoansDiff
    {
        decimal LoanBelow5000();
        decimal Loan5000to30000();
        decimal Loan30000AndUp();
    }
}
