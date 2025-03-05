using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    internal class WalletPayment : PaymentProcessor
    {
        protected override void PerformPayment()
        {
            Log("Обработка платежа через электронный кошелек...", ConsoleColor.Magenta);
            // Логика обработки платежа через электронный кошелек
        }

        protected override bool IsPaymentValid()
        {
            // Логика проверки электронного кошелька
            Log("Проверка баланса электронного кошелька...", ConsoleColor.Yellow);
            return true; // В реальной системе здесь будет сложная логика
        }

        protected override void SendNotification()
        {
            Log("Отправка уведомления в приложение электронного кошелька.", ConsoleColor.Blue);
        }
    }
}
