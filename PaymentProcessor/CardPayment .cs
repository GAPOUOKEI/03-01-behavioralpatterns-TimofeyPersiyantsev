using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    internal class CardPayment : PaymentProcessor
    {
        protected override void PerformPayment()
        {
            Log("Обработка платежа по карте...", ConsoleColor.Magenta);
            // Логика обработки платежа по карте
        }

        protected override bool IsPaymentValid()
        {
            // Логика проверки карты
            Log("Проверка данных карты...", ConsoleColor.Yellow);
            return true; // В реальной системе здесь будет сложная логика
        }

        protected override void SendNotification()
        {
            Log("Отправка уведомления на email о платеже по карте.", ConsoleColor.Blue);
        }
    }
}
