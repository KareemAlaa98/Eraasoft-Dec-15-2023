using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Account
    {
        private decimal _balance;
        private string _name;

        //public decimal Balance { get; set; }
        //public string Name { get; set; }

        public Account(string name, decimal startingBalance)
        {
            _name = name;
            _balance = startingBalance;
        }

        public string Name
        {
            get { return _name; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public bool Deposit(decimal ammountToDeposit)
        {
            if (ammountToDeposit > 0)
            {
                _balance += ammountToDeposit;
                Console.WriteLine($"Deposite successful your balance is {_balance}\n");
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal ammountToWithdraw)
        {
            if (_balance - ammountToWithdraw >= 0 && ammountToWithdraw > 0)
            {
                _balance -= ammountToWithdraw;
                Console.WriteLine($"Withdraw successful your balance is {_balance}\n");
                return true;
            }
            Withdraw(ammountToWithdraw);
            return false;
        }

        public void Print()
        {
            Console.WriteLine($"The Account Holder Name: {this.Name}, and the balance is : {this.Balance}\n");
        }
    }
}
