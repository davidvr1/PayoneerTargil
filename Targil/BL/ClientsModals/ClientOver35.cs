using BL.Abstract;
using BL.Factories;
using BL.Interfaces;

namespace BL.ClientsModals
{
    internal class ClientOver35 : ClientBase, IClient
    {
        public override decimal  CalculateLoan(decimal amount, int period)
        {
            decimal total = (amount * (100 + CalcInterest(amount, period))) / 100;
            return total;
        }

        private decimal CalcInterest(decimal amount, int period)
        {
            decimal extreInterest = GetInterestForExtraMonthes(period);
            ILoansDiff calc = LoanFactory.GetIntersetCalc(typeof(ClientOver35));
            if (amount < 5000)
            {
                return calc.LoanBelow5000() + extreInterest;
            }
            else if (amount < 30000)
            {
                return calc.Loan5000to30000() + extreInterest;
            }
            return calc.Loan30000AndUp() + extreInterest;
        }

    }
}
