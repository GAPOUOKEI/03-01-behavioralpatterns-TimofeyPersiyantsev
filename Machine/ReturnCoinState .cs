using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal class ReturnCoinState : IState
    {
        private readonly VendingMachine _machine;

        public ReturnCoinState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Log("Пожалуйста, заберите возвращенную монету перед внесением новой.", ConsoleColor.Yellow);
        }

        public void SelectDrink()
        {
            Log("Пожалуйста, заберите возвращенную монету перед выбором напитка.", ConsoleColor.Yellow);
        }

        public void Dispense()
        {
            Log("Невозможно выдать напиток. Монета возвращена.", ConsoleColor.Red);
        }

        public void ReturnCoin()
        {
            Log("Монета уже возвращена.", ConsoleColor.Yellow);
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
