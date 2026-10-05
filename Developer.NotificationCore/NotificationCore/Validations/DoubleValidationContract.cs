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
        public Contract<T> IsNull(double? val, string message)
        {
            if (val == null)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for nulo, adiciona uma notificação (If the value is null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNull(double? val, string key, string message)
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
        public Contract<T> IsNotNull(double? val, string message)
        {
            if (val != null)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não for nulo, adiciona uma notificação (If the value is not null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(double? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNull (Se Não Nulo)

        #region IsGreaterThan (Se Maior Que)

        /// <summary>
        /// Se o valor for maior que o comparador, adiciona uma notificação (If the value is greater than the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, double comparer, string message)
        {
            if (val > comparer)
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
        public Contract<T> IsGreaterThan(double val, double comparer, string key, string message)
        {
            if (val > comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan (Se Maior ou Igual Que)

        /// <summary>
        /// Se o valor for maior ou igual ao comparador, adiciona uma notificação (If the value is greater than or equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, double comparer, string message)
        {
            if (val >= comparer)
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
        public Contract<T> IsGreaterOrEqualsThan(double val, double comparer, string key, string message)
        {
            if (val >= comparer)
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
        public Contract<T> IsLowerThan(double val, double comparer, string message)
        {
            if (val < comparer)
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
        public Contract<T> IsLowerThan(double val, double comparer, string key, string message)
        {
            if (val < comparer)
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
        public Contract<T> IsLowerOrEqualsThan(double val, double comparer, string message)
        {
            if (val <= comparer)
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
        public Contract<T> IsLowerOrEqualsThan(double val, double comparer, string key, string message)
        {
            if (val <= comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion IsLowerOrEqualsThan (Se Menor ou Igual Que)

        #region IsMinValue (Se Valor Mínimo)

        /// <summary>
        /// Se o valor for igual ao valor mínimo, adiciona uma notificação (If the value is equal to the minimum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsMinValue(double val, string message)
        {
            if (val == double.MinValue)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for igual ao valor mínimo, adiciona uma notificação (If the value is equal to the minimum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsMinValue(double val, string key, string message)
        {
            if (val == double.MinValue)
                AddNotification(key, message);

            return this;
        }

        #endregion IsMinValue (Se Valor Mínimo)

        #region IsNotMinValue (Se Não Valor Mínimo)

        /// <summary>
        /// Se o valor não for igual ao valor mínimo, adiciona uma notificação (If the value is not equal to the minimum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(double val, string message)
        {
            if (val != double.MinValue)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não for igual ao valor mínimo, adiciona uma notificação (If the value is not equal to the minimum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(double val, string key, string message)
        {
            if (val != double.MinValue)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotMinValue (Se Não Valor Mínimo)

        #region IsMaxValue (Se Valor Máximo)

        /// <summary>
        /// Se o valor for igual ao valor máximo, adiciona uma notificação (If the value is equal to the maximum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(double val, string message)
        {
            if (val == double.MaxValue)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for igual ao valor máximo, adiciona uma notificação (If the value is equal to the maximum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(double val, string key, string message)
        {
            if (val == double.MaxValue)
                AddNotification(key, message);

            return this;
        }

        #endregion IsMaxValue (Se Valor Máximo)

        #region IsNotMaxValue (Se Não Valor Máximo)

        /// <summary>
        /// Se o valor não for igual ao valor máximo, adiciona uma notificação (If the value is not equal to the maximum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(double val, string message)
        {
            if (val != double.MaxValue)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não for igual ao valor máximo, adiciona uma notificação (If the value is not equal to the maximum value, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(double val, string key, string message)
        {
            if (val != double.MaxValue)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotMaxValue (Se Não Valor Máximo)

        #region AreEquals (São iguais)

        /// <summary>
        /// Se o valor igual ao comparador, adiciona uma notificação (If the value is equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, double comparer, string message)
        {
            if (val == comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor igual ao comparador, adiciona uma notificação (If the value is equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, double comparer, string key, string message)
        {
            if (val == comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion AreEquals (São iguais)

        #region AreNotEquals (Não são iguais)

        /// <summary>
        /// Se o valor não for igual ao comparador, adiciona uma notificação (If the value is not equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, double comparer, string message)
        {
            if (val != comparer)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não for igual ao comparador, adiciona uma notificação (If the value is not equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, double comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion AreNotEquals (Não são iguais)

        #region IsBetween (Está entre)

        /// <summary>
        /// Se o valor estiver entre o comparador, adiciona uma notificação (If the value is between the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="start">O valor inicial do intervalo (The start value of the range).</param>
        /// <param name="end">O valor final do intervalo (The end value of the range).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, double start, double end, string message)
        {
            if (val >= start && val <= end)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor estiver entre o comparador, adiciona uma notificação (If the value is between the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="start">O valor inicial do intervalo (The start value of the range).</param>
        /// <param name="end">O valor final do intervalo (The end value of the range).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, double start, double end, string key, string message)
        {
            if (val >= start && val <= end)
                AddNotification(key, message);

            return this;
        }

        #endregion IsBetween (Está entre)

        #region IsNotBetween (Não está entre)

        /// <summary>
        /// Se o valor não estiver entre o comparador, adiciona uma notificação (If the value is not between the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="start">O valor inicial do intervalo (The start value of the range).</param>
        /// <param name="end">O valor final do intervalo (The end value of the range).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, double start, double end, string message)
        {
            if (val < start || val > end)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não estiver entre o comparador, adiciona uma notificação (If the value is not between the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="start">O valor inicial do intervalo (The start value of the range).</param>
        /// <param name="end">O valor final do intervalo (The end value of the range).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, double start, double end, string key, string message)
        {
            if (val < start || val > end)
                AddNotification(key, message);

            return this;
        }

        #endregion IsBetween (Está entre)

        #region Contains (Contém)

        /// <summary>
        /// Se o valor estiver contido na lista, adiciona uma notificação (If the value is contained in the list, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="list">A lista de valores (The list of values).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Contains(double val, IEnumerable<double> list, string message)
        {
            if (list.Any(x => x == val))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor estiver contido na lista, adiciona uma notificação (If the value is contained in the list, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="list">A lista de valores (The list of values).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Contains(double val, IEnumerable<double> list, string key, string message)
        {
            if (list.Any(x => x == val))
                AddNotification(key, message);

            return this;
        }

        #endregion Contains (Contém)

        #region NotContains (Não contém)

        /// <summary>
        /// Se o valor não estiver contido na lista, adiciona uma notificação (If the value is not contained in the list, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="list">A lista de valores (The list of values).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> NotContains(double val, IEnumerable<double> list, string message)
        {
            if (!list.Any(x => x == val))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não estiver contido na lista, adiciona uma notificação (If the value is not contained in the list, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="list">A lista de valores (The list of values).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> NotContains(double val, IEnumerable<double> list, string key, string message)
        {
            if (!list.Any(x => x == val))
                AddNotification(key, message);

            return this;
        }

        #endregion NotContains (Não contém)

    }
}
