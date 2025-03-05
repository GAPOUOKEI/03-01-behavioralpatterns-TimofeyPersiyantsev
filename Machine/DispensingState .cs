using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal class DispensingState : IState
    {
        private readonly VendingMachine _machine;

        public DispensingState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Log("Подождите, идет выдача напитка.", ConsoleColor.Yellow);
        }

        public void SelectDrink()
        {
            Log("Подождите, идет выдача напитка.", ConsoleColor.Yellow);
        }

        public void Dispense()
        {
            Log("Напиток выдан. Ожидание новой монеты.", ConsoleColor.Green);
            _machine.SetState(_machine.GetWaitingForCoinState());
        }

        public void ReturnCoin()
        {
            Log("Невозможно вернуть монету во время выдачи напитка.", ConsoleColor.Red);
        }
        private void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
