using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid4
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IAccountFees
    {
        decimal getAccountFee(decimal amountFee, decimal percentage);
    }

    public class BankAccount
    {
        public readonly IAccountFees _accountFees;
        public readonly string _accountType;

        public BankAccount(string accountType, IAccountFees accountFees)
        {
            _accountType = accountType;
            _accountFees = accountFees;
        }

        public decimal getAccountFee(decimal amountFee, decimal percentage)
        {
            return _accountFees.getAccountFee(amountFee, percentage);
        }
    }

    public class SpecialBankAccount : IAccountFees
    {
        public readonly decimal _specialAccountFee;

        public SpecialBankAccount(decimal specialAccountFee)
        {
            _specialAccountFee = specialAccountFee;
        }

        public decimal getAccountFee(decimal amountFee, decimal percentage)
        {
            return _specialAccountFee * amountFee * percentage;
        }
    }

    public class VIPBankAccount : IAccountFees
    {
        public readonly decimal _vipAccountFee;

        public VIPBankAccount(decimal vipAccountFee)
        {
            _vipAccountFee = vipAccountFee;
        }

        public decimal getAccountFee(decimal amountFee, decimal percentage)
        {
            return _vipAccountFee * amountFee * percentage;
        }
    }
}
