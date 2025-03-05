using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal class WaitingForCoinState : IState
    {
        private readonly VendingMachine _machine;

        public WaitingForCoinState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Log("Монета принята. Выберите напиток.", ConsoleColor.Green);
            _machine.SetState(_machine.GetDrinkSelectionState());
        }

        public void SelectDrink()
        {
            Log("Пожалуйста, сначала внесите монету.", ConsoleColor.Red);
        }

        public void Dispense()
        {
            Log("Пожалуйста, внесите монету и выберите напиток.", ConsoleColor.Red);
        }

        public void ReturnCoin()
        {
            Log("Нет монет для возврата.", ConsoleColor.Yellow);
        }
        private void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
