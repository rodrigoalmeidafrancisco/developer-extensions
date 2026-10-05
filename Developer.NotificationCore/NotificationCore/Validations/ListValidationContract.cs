using System.Collections.Generic;
using System.Linq;

namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        #region IsNull (Se Nulo)

        /// <summary>
        /// Se o valor for nulo, adiciona uma notificação (If the value is null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNull<TList>(IEnumerable<TList> val, string message)
        {
            if (val == null)
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se o valor for nulo, adiciona uma notificação (If the value is null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNull<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNull (Se Nulo)

        #region IsNotNull (Se Não Nulo)

        /// <summary>
        /// Se o valor não for nulo, adiciona uma notificação (If the value is not null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNull<TList>(IEnumerable<TList> val, string message)
        {
            if (val != null)
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se o valor não for nulo, adiciona uma notificação (If the value is not null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNull<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNull (Se Não Nulo)

        #region IsEmpty (Se Vazio)

        /// <summary>
        /// Se o valor for vazio, adiciona uma notificação (If the value is empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsEmpty<TList>(IEnumerable<TList> val, string message)
        {
            if (val != null && !val.Any())
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se o valor for vazio, adiciona uma notificação (If the value is empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsEmpty<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val != null && !val.Any())
                AddNotification(key, message);

            return this;
        }

        #endregion IsEmpty (Se Vazio)

        #region IsNotEmpty (Se Não Vazio)

        /// <summary>
        /// Se o valor não for vazio, adiciona uma notificação (If the value is not empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotEmpty<TList>(IEnumerable<TList> val, string message)
        {
            if (val != null && val.Any())
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se o valor não for vazio, adiciona uma notificação (If the value is not empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotEmpty<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val != null && val.Any())
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotEmpty (Se Não Vazio)

        #region IsGreaterThan (Se Maior Que)

        /// <summary>
        /// Se o valor for maior que o comparador, adiciona uma notificação (If the value is greater than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, int comparer, string message)
        {
            if (val?.Count() > comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for maior que o comparador, adiciona uma notificação (If the value is greater than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() > comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Se o valor for maior que o comparador, adiciona uma notificação (If the value is greater than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, long comparer, string message)
        {
            if (val?.Count() > comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for maior que o comparador, adiciona uma notificação (If the value is greater than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, long comparer, string key, string message)
        {
            if (val?.Count() > comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion IsGreaterThan (Se Maior Que)

        #region IsGreaterOrEqualsThan (Se Maior ou Igual Que)

        /// <summary>
        /// Se o valor for maior ou igual ao comparador, adiciona uma notificação (If the value is greater than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string message)
        {
            if (val?.Count() >= comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for maior ou igual ao comparador, adiciona uma notificação (If the value is greater than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Se o valor for maior ou igual ao comparador, adiciona uma notificação (If the value is greater than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, long comparer, string message)
        {
            if (val?.Count() >= comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for maior ou igual ao comparador, adiciona uma notificação (If the value is greater than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, long comparer, string key, string message)
        {
            if (val?.Count() >= comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion IsGreaterOrEqualsThan (Se Maior ou Igual Que)

        #region IsLowerThan (Se Menor Que)

        /// <summary>
        /// Se o valor for menor que o comparador, adiciona uma notificação (If the value is lower than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, int comparer, string message)
        {
            if (val?.Count() < comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for menor que o comparador, adiciona uma notificação (If the value is lower than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Se o valor for menor que o comparador, adiciona uma notificação (If the value is lower than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, long comparer, string message)
        {
            if (val?.Count() < comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for menor que o comparador, adiciona uma notificação (If the value is lower than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, long comparer, string key, string message)
        {
            if (val?.Count() < comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion IsLowerThan (Se Menor Que)

        #region IsLowerOrEqualsThan (Se Menor ou Igual Que)

        /// <summary>
        /// Se o valor for menor ou igual ao comparador, adiciona uma notificação (If the value is lower than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string message)
        {
            if (val?.Count() <= comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for menor ou igual ao comparador, adiciona uma notificação (If the value is lower than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() <= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Se o valor for menor ou igual ao comparador, adiciona uma notificação (If the value is lower than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, long comparer, string message)
        {
            if (val?.Count() <= comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for menor ou igual ao comparador, adiciona uma notificação (If the value is lower than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, long comparer, string key, string message)
        {
            if (val?.Count() <= comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion IsLowerOrEqualsThan (Se Menor ou Igual Que)
    }
}
