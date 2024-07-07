using BL.ClientsModals;
using BL.Interfaces;
using BL.LoanCalc;

namespace BL.Factories
{
    public static class LoanFactory
    {
        public static ILoansDiff GetIntersetCalc(Type type)
        {
            switch (type.Name)
            {
                case nameof(ClientBetween20To35):
                    return new LoanCalcBeteen20to35();
                case nameof(ClientOver35):
                    return new LoanCalcOver35();
                default:
                    return new LoanCalcOver35();
            }
        }
    }
}
