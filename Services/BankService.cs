using ConsoleApp1.Models;
using ConsoleApp1.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    static public class BankService
    {



        public static void Transfer (Account From , Account To , decimal Amoount)
        {
            if(From.WithDraw(Amoount))
            {
                To.Deposit(Amoount);
                Logger.Log($"Successfully transferred {Amoount} From {From.AccountNumber} To {To.AccountNumber}");
            }
            else
            {

                Logger.Log($"Transfer failed from {From.AccountNumber}: Insufficient balance or limit reached.");
            }
        }


    }
}
