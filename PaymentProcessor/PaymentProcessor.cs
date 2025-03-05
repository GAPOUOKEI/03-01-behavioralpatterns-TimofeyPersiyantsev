using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    abstract class PaymentProcessor
    {
        // Шаблонный метод
        public void ProcessPayment()
        {
            Log("Начало обработки платежа.", ConsoleColor.Cyan);

            ValidatePayment();
            PerformPayment();
            NotifyUser();

            Log("Обработка платежа завершена.", ConsoleColor.Cyan);
        }

        // Общие шаги
        private void ValidatePayment()
        {
            Log("Проверка платежа...", ConsoleColor.Yellow);
            if (IsPaymentValid())
            {
                Log("Платеж проверен и одобрен.", ConsoleColor.Green);
            }
            else
            {
                Log("Платеж не прошел проверку.", ConsoleColor.Red);
                throw new Exception("Платеж недействителен.");
            }
        }

        private void NotifyUser()
        {
            Log("Уведомление пользователя об успешном платеже.", ConsoleColor.Blue);
            SendNotification();
        }

        // Абстрактные методы, которые должны быть реализованы в подклассах
        protected abstract void PerformPayment();
        protected abstract bool IsPaymentValid();
        protected abstract void SendNotification();

        // Вспомогательный метод для логирования с цветом
        protected void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

   
