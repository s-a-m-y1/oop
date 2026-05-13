using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class SavingsAccount:Account
    {
      public  decimal InterestRate { get; set; }

        public  SavingsAccount(string AccountNumber, decimal initialBalance, decimal interest) : base(AccountNumber, initialBalance)
        {
            this.InterestRate = interest;

        }

        public override bool WithDraw(decimal Amount)
        {
            if(Balance - Amount>=500)
            {

                Balance -= Amount;
                return true;
            }
            return false;

        }
    }
}
