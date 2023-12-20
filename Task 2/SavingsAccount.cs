using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    public class SavingsAccount : Account
    {
        protected double interestRate;

        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double _interestRate = 1.0) : base(name, balance)
        {
            this.interestRate = _interestRate;
        }

        public double InterestRate { get; }

        public new bool Deposit(double amount)
        {
            amount = amount * interestRate / 100;
            return base.Deposit(amount);
        }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"[Account: {base.name}: {base.balance}: {interestRate}]";
            //return $"[Account: {base.ToString()}: {interestRate}]";
        }
    }

}
