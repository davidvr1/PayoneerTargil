using BL.Abstract;
using BL.Interfaces;

namespace BL.ClientsModals
{
    public class ClientBelow20 : ClientBase, IClient
    {
        public override decimal CalculateLoan(decimal amount, int period)
        {
            decimal extreInterest = GetInterestForExtraMonthes(period);
            decimal total=(amount*(102 + Consts.Consts.PRIME  + extreInterest))/100;
            return total;
        }
    }
}
