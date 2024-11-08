using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;

namespace Banking
{
    public class Account
    {
        public event Operation underBalance;
        public event Operation overBalance;

        public event Operation rolloutEvent;
        public double Balance { get; set; }

        public Account(double initialAmount)
        {
            Balance = initialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;

            if (result <= 10000)
            {
                underBalance(5);
            }

            Balance = result;
        }

        public void Deposit(double amount)
        {
            double result = Balance + amount;
            if (result >= 250000)
            {
                overBalance(15);
            }
        }  
        public void Rollout(float amount)
        {
            rolloutEvent(amount);
        }

    }
}
