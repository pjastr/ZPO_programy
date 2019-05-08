using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid3
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class BankAccount
    {
        public virtual decimal getAccountFee(decimal amountFee, decimal percentage)
        {
            return amountFee * percentage;
        }
    }

    public class SpecialBankAccount : BankAccount
    {
        public override decimal getAccountFee(decimal amountFee, decimal percentage)
        {
            return amountFee * percentage;
        }
    }

    public class VIPBankAccount : SpecialBankAccount
    {
        public override decimal getAccountFee(decimal amountFee, decimal percentage)
        {
            return amountFee * percentage;
        }
    }
}
