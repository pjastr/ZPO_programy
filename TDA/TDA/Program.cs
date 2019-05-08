using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDA
{
    //kod ze strony http://itcraftsman.pl/uzyteczne-koncepty-projektowe-kiss-dry-yagni-tda-oraz-separation-of-concerns/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //zły przyklad
    public class PaymentAccount
    {
        public int CustomerID { get; set; }

        public int TotalBalance { get; set; }
    }

    public class PaymentService
    {
        public void StandardCustomer(int amount, int customerId)
        {
            var currentAcc = AccountsRepository.FindAccountByCustomerId(customerId);

            if (currentAcc.TotalBalance < amount)
            {
                throw new Exception("Not enough funds.");
            }

            currentAcc.TotalBalance -= amount;
        }

        public void PremiumCustomer(int amount, int customerId)
        {
            var currentAcc = AccountsRepository.FindAccountByCustomerId(customerId);

            if (currentAcc.TotalBalance < amount)
            {
                throw new Exception("Not enough funds.");
            }

            currentAcc.TotalBalance += amount;
        }
    }

    public static class AccountsRepository
    {
        public static PaymentAccount FindAccountByCustomerId(int customerId)
        {
            return new PaymentAccount
            {
                TotalBalance = 200,
                CustomerID = customerId
            };
        }
    }
}
