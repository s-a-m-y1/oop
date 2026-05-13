using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public interface Interfaces
     {
        bool WithDraw(decimal Amount);
        bool Deposit(decimal Amount);

    }
}