using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Account:Interfaces// this Is No't Object  Clsss Only 
    {

        public string AccountNumber { get; set; }

        protected decimal Balance { get; set; }

        // create THe Constractor

        public Account(string AcountNumber , decimal Balance ) { this.AccountNumber = AccountNumber; this.Balance = Balance; }


        // call methods  interface 

        public abstract bool WithDraw(decimal Amount);
        public bool Deposit(decimal Amount)
        {
            //Balance += (Amount > 0) ? Amount : 0;
            if (Amount > 0)
            {
                Balance += Amount;
                return true;
            }
            return false;
        }



    }
}
