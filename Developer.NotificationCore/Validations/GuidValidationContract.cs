using System;
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
        public Contract<T> IsNull(Guid? val, string message)
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
        public Contract<T> IsNull(Guid? val, string key, string message)
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
        public Contract<T> IsNotNull(Guid? val, string message)
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
        public Contract<T> IsNotNull(Guid? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNull (Se Não Nulo)

        #region AreEquals (São iguais)

        /// <summary>
        /// Se o valor igual ao comparador, adiciona uma notificação (If the value is equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreEquals(Guid val, Guid comparer, string message)
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
        public Contract<T> AreEquals(Guid val, Guid comparer, string key, string message)
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
        public Contract<T> AreNotEquals(Guid val, Guid comparer, string message)
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
        public Contract<T> AreNotEquals(Guid val, Guid comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion AreNotEquals (Não são iguais)

        #region Contains (Contém)

        /// <summary>
        /// Se o valor estiver contido na lista, adiciona uma notificação (If the value is contained in the list, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="list">A lista de valores (The list of values).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Contains(Guid val, IEnumerable<Guid> list, string message)
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
        public Contract<T> Contains(Guid val, IEnumerable<Guid> list, string key, string message)
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
        public Contract<T> NotContains(Guid val, IEnumerable<Guid> list, string message)
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
        public Contract<T> NotContains(Guid val, IEnumerable<Guid> list, string key, string message)
        {
            if (!list.Any(x => x == val))
                AddNotification(key, message);

            return this;
        }

        #endregion NotContains (Não contém)

    }
}
