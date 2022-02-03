using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        private decimal _balance;

        private bool _isPastDue;

        private decimal _annualInterestRate;

        private Customer _customerInfo;

        private int _accountNumber;






        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public bool IsPastDue
        {
            get { return _isPastDue; }
            set { _isPastDue = value; }
        }

        public decimal AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }

        public Customer CustomerInfo
        {
            get { return _customerInfo; }
            set { _customerInfo = value; }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }


        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }
        public override string ToString()
        {
            return string.Format("Account Number: {0}\nCustomer Info: {1}\nBalance: {2}\nIs Past Due?: {3}\nAnnual Interest Rate: {4}", AccountNumber, CustomerInfo, Balance, IsPastDue, AnnualInterestRate);
        }

    }
}
