
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CheckingAccount : Account
    {
        double fee = 1.50;

        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) : base(name, balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public new bool Withdraw(double amount)
        {
            amount = amount - this.fee;
            return base.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"[Account: {base.name}: {base.balance}: {this.fee}]";
        }
    }
}
