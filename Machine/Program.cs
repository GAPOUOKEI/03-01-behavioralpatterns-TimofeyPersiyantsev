namespace Machine
{
    /*
    * ФИО студента: Персиянцев Тимофей Сергеевич
    * номер варианта: 1
    * условие задачи (скопировать из листа задания): 
    * Реализуйте автомат, который может находиться в различных состояниях 
    * (ожидание монет, ожидание выбора напитка, выдача напитка). 
    * Доступные действия зависят от текущего состояния.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();

            // Пример работы автомата
            machine.InsertCoin();
            machine.SelectDrink();
            machine.Dispense();

            Console.WriteLine("\nПопытка вернуть монету");
            machine.ReturnCoin();

            Console.WriteLine("\nПопытка выбрать напиток без монеты");
            machine.SelectDrink();

            Console.WriteLine("\nПопытка выдать напиток без выбора");
            machine.Dispense();
        }
    }
}
