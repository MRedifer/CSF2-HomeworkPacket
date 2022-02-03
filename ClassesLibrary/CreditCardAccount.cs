using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        private int _accountNumber;

        private decimal _balance;

        private bool _isPastDue;

        private decimal _annualInterestRate;

        private Customer _customerInfo;
        
        private ContactInfo c1;
        

        public int AccountNumbers { get; set; }

        public decimal Balance { get; set; }

        public bool IsPastDue { get; set; }

        public decimal AnnualInterestRate { get; set; }

        public Customer CustomerInfo { get; set; }


        public CreditCardAccount(int accountNumbers, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumbers = accountNumbers;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount(int v1, ContactInfo c1, int v2, bool v3, decimal v4)
        {
            
        }
    }
}
