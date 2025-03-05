using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal interface IState
    {
        void InsertCoin();
        void SelectDrink();
        void Dispense();
        void ReturnCoin();
    }
}
