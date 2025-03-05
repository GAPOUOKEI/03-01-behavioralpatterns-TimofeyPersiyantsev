namespace PaymentProcessor
{
    /*
     * ФИО студента: Персиянцев Тимофей Сергеевич
     * номер варианта: 1
     * условие задачи (скопировать из листа задания): 
     * Разработайте систему для обработки платежей, 
     * где различные способы оплаты (карта, электронный кошелек, наличные) 
     * будут реализованы через шаблонный метод. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Обработка платежа по карте");
                PaymentProcessor cardPayment = new CardPayment();
                cardPayment.ProcessPayment();

                Console.WriteLine("\nОбработка платежа через электронный кошелек");
                PaymentProcessor walletPayment = new WalletPayment();
                walletPayment.ProcessPayment();

                Console.WriteLine("\nОбработка наличного платежа");
                PaymentProcessor cashPayment = new CashPayment();
                cashPayment.ProcessPayment();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
