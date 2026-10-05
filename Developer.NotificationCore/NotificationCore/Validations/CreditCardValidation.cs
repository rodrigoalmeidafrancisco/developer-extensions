using Developer.NotificationCore.Patterns;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requer uma string que seja um número de cartão de crédito. (Requires a string is a Credit Card number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsCreditCard(string val, string message)
        {
            val = Regex.Replace(val ?? string.Empty, NotificationCoreRegexPatterns.OnlyNumbersPattern, "");

            if (string.IsNullOrWhiteSpace(val))
            {
                AddNotification(message);
                return this;
            }

            var even = false;
            var checksum = 0;

            foreach (var digit in val.ToCharArray().Reverse())
            {
                if (!char.IsDigit(digit))
                {
                    AddNotification(message);
                    return this;
                }

                var value = (digit - '0') * (even ? 2 : 1);
                even = !even;

                while (value > 0)
                {
                    checksum += value % 10;
                    value /= 10;
                }
            }

            if (checksum % 10 != 0)
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Requer uma string que seja um número de cartão de crédito. (Requires a string is a Credit Card number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsCreditCard(string val, string key, string message)
        {
            val = Regex.Replace(val ?? string.Empty, NotificationCoreRegexPatterns.OnlyNumbersPattern, "");

            if (string.IsNullOrWhiteSpace(val))
            {
                AddNotification(key, message);
                return this;
            }

            var even = false;
            var checksum = 0;

            foreach (var digit in val.ToCharArray().Reverse())
            {
                if (!char.IsDigit(digit))
                {
                    AddNotification(key, message);
                    return this;
                }

                var value = (digit - '0') * (even ? 2 : 1);
                even = !even;

                while (value > 0)
                {
                    checksum += value % 10;
                    value /= 10;
                }
            }

            if (checksum % 10 != 0)
                AddNotification(key, message);

            return this;
        }

    }
}
