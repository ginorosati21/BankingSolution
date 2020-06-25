namespace BankingDomain
{
    public interface ICalculateBonuses
    {
        decimal GetDepostitBonusFor(decimal amountToDeposit, decimal currentBalance);
    }
}