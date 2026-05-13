using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount ac1 = new SavingsAccount("Samy11", 10000, 1);
            SavingsAccount ac2 = new SavingsAccount("Samy12", 10000, 102);

            BankService.Transfer(ac2, ac1, 150); 
        }
    }
   
}
