using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDAGOOD
{
    //kod ze strony http://itcraftsman.pl/uzyteczne-koncepty-projektowe-kiss-dry-yagni-tda-oraz-separation-of-concerns/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PaymentAccount
    {
        public int CustomerID { get; set; }

        public int TotalBalance { get; set; }

        public PaymentAccount(int customerID, int totalBalance)
        {
            this.CustomerID = customerID;
            this.TotalBalance = totalBalance;
        }

        public void StandardCharge(int amount)
        {
            if (TotalBalance < amount)
            {
                throw new Exception("Not enough funds.");
            }

            TotalBalance -= amount;
        }

        public void PremiumCharge(int amount)
        {
            if (TotalBalance < amount)
            {
                throw new Exception("Not enough funds.");
            }

            TotalBalance += amount;
        }
    }

    public class PaymentService
    {
        public void StandardCustomer(int amount, int customerId)
        {
            var currentAcc = AccountsRepository.FindAccountByCustomerId(customerId);

            currentAcc.StandardCharge(amount);
        }

        public void PremiumCustomer(int amount, int customerId)
        {
            var currentAcc = AccountsRepository.FindAccountByCustomerId(customerId);

            currentAcc.PremiumCharge(amount);
        }
    }

    public static class AccountsRepository
    {
        public static PaymentAccount FindAccountByCustomerId(int customerId)
        {
            return new PaymentAccount(customerId, 1200);
        }
    }
}
