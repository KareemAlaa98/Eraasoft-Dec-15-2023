using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    public class TrustAccount : SavingsAccount
    {
        const double bonus = 50.00;
        const int maxWithdrawsPerYear = 3;
        int withdrawsThisYear;
        double withdrawPercent;

        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double _interestRate = 1.0) : base(name, balance, _interestRate)
        {
            this.withdrawsThisYear = 0;
            this.withdrawPercent = 0.2;
        }

        public new bool Deposit(double amount)
        {
            if (amount >= 5000.00)
            {
                amount += bonus;
            }
            return base.Deposit(amount);
        }

        public new bool Withdraw(double amount)
        {
            if (amount < balance * withdrawPercent && withdrawsThisYear < maxWithdrawsPerYear)
            {
                withdrawsThisYear++;
                return base.Withdraw(amount);
            }
            return false;
        }

        public override string ToString()
        {
            return $"[Account: {base.name}: {base.balance}: {base.interestRate}: maximum num of withdraws is {maxWithdrawsPerYear}]";
        }
    }
}
