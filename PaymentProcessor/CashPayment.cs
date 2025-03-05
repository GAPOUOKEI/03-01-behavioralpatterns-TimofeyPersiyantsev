using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    internal class CashPayment : PaymentProcessor
    {
        protected override void PerformPayment()
        {
            Log("Прием наличных...", ConsoleColor.Magenta);
            // Логика приема наличных
        }

        protected override bool IsPaymentValid()
        {
            // Логика проверки наличных
            Log("Проверка наличных...", ConsoleColor.Yellow);
            return true; // В реальной системе здесь будет сложная логика
        }

        protected override void SendNotification()
        {
            Log("Выдача чека за наличный платеж.", ConsoleColor.Blue);
        }
    }
}
