using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class MortgageFacade
    {
        private Bank _bank = new Bank();
        private Loan _Loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);

            bool isEligible = true;

            if (!_bank.HasSufficientSaving(customer))
                isEligible = false;
            if (!_Loan.HasNoBadLoans(customer))
                isEligible = false;
            if (!_credit.HasGoodCredit(customer))
                isEligible = false;

            return isEligible;
        }
    }
}
