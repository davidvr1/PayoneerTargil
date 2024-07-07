using BL.Interfaces;

namespace BL.LoanCalc
{
    internal class LoanCalcOver35:ILoansDiff
    {
        public decimal LoanBelow5000()
        {
            return 1.5m + BL.Consts.Consts.PRIME;
        }
        public decimal Loan5000to30000()
        {
            return 3m + BL.Consts.Consts.PRIME;
        }
        public decimal Loan30000AndUp()
        {

            return 1m;
        }
    }
}
