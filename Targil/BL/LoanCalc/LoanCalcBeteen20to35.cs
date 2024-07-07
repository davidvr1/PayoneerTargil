using BL.Interfaces;

namespace BL.LoanCalc
{
    public class LoanCalcBeteen20to35 : ILoansDiff
    {
        public decimal LoanBelow5000()
        {
            return 2;
        }
        public decimal Loan5000to30000()
        {
            return 1.5m + BL.Consts.Consts.PRIME;
        }
        public decimal Loan30000AndUp()
        {
            return 1m + BL.Consts.Consts.PRIME; ;
        }
    }
}
