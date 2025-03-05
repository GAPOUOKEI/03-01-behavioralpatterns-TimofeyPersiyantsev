using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal class DrinkSelectionState : IState
    {
        private readonly VendingMachine _machine;

        public DrinkSelectionState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Log("Монета уже внесена.", ConsoleColor.Yellow);
        }

        public void SelectDrink()
        {
            if (_machine.HasDrinks())
            {
                Log("Напиток выбран. Идет выдача...", ConsoleColor.Green);
                _machine.SetState(_machine.GetDispensingState());
            }
            else
            {
                Log("Напитки закончились. Возврат монеты.", ConsoleColor.Red);
                _machine.SetState(_machine.GetReturnCoinState());
            }
        }

        public void Dispense()
        {
            Log("Сначала выберите напиток.", ConsoleColor.Red);
        }

        public void ReturnCoin()
        {
            Log("Монета возвращена.", ConsoleColor.Yellow);
            _machine.SetState(_machine.GetWaitingForCoinState());
        }
        private void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
