using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal class VendingMachine
    {
        private IState _currentState;
        private readonly List<string> _drinks = new List<string> { "Кола", "Пепси", "Фанта" };

        public VendingMachine()
        {
            _currentState = new WaitingForCoinState(this);
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public IState GetWaitingForCoinState() => new WaitingForCoinState(this);
        public IState GetDrinkSelectionState() => new DrinkSelectionState(this);
        public IState GetDispensingState() => new DispensingState(this);
        public IState GetReturnCoinState() => new ReturnCoinState(this);

        public bool HasDrinks() => _drinks.Count > 0;

        public void InsertCoin() => _currentState.InsertCoin();
        public void SelectDrink() => _currentState.SelectDrink();
        public void Dispense() => _currentState.Dispense();
        public void ReturnCoin() => _currentState.ReturnCoin();
        private void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
