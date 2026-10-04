using Developer.NotificationCore.Patterns;
using System;

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
        public Contract<T> IsNull(string val, string message)
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
        public Contract<T> IsNull(string val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNull (Se Nulo)

        #region IsNullOrEmpty (Se Nulo ou Vazio)

        /// <summary>
        /// Se o valor for nulo ou vazio, adiciona uma notificação (If the value is null or empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNullOrEmpty(string val, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for nulo ou vazio, adiciona uma notificação (If the value is null or empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNullOrEmpty(string val, string key, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddNotification(key, message);

            return this;
        }

        #endregion IsNullOrEmpty (Se Nulo ou Vazio)

        #region IsNullOrWhiteSpace (Se Nulo ou Composto Apenas por Espaços em Branco)

        /// <summary>
        /// Se o valor for nulo ou composto apenas por espaços em branco, adiciona uma notificação (If the value is null or consists only of white-space characters, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNullOrWhiteSpace(string val, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for nulo ou composto apenas por espaços em branco, adiciona uma notificação (If the value is null or consists only of white-space characters, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNullOrWhiteSpace(string val, string key, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
                AddNotification(key, message);

            return this;
        }

        #endregion IsNullOrWhiteSpace (Se Nulo ou Composto Apenas por Espaços em Branco)

        #region IsNotNull (Se Não Nulo)

        /// <summary>
        /// Se o valor não for nulo, adiciona uma notificação (If the value is not null, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(string val, string message)
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
        public Contract<T> IsNotNull(string val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNull (Se Não Nulo)

        #region IsNotNullOrEmpty (Se Não Nulo ou Vazio)

        /// <summary>
        /// Se o valor não for nulo ou vazio, adiciona uma notificação (If the value is not null or empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrEmpty(string val, string message)
        {
            if (!string.IsNullOrEmpty(val))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não for nulo ou vazio, adiciona uma notificação (If the value is not null or empty, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrEmpty(string val, string key, string message)
        {
            if (!string.IsNullOrEmpty(val))
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNullOrEmpty (Se Não Nulo ou Vazio)

        #region IsNotNullOrWhiteSpace (Se Não Nulo ou Composto Apenas por Espaços em Branco)

        /// <summary>
        /// Se o valor não for nulo ou composto apenas por espaços em branco, adiciona uma notificação (If the value is not null or consists only of white-space characters, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrWhiteSpace(string val, string message)
        {
            if (!string.IsNullOrWhiteSpace(val))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não for nulo ou composto apenas por espaços em branco, adiciona uma notificação (If the value is not null or consists only of white-space characters, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrWhiteSpace(string val, string key, string message)
        {
            if (!string.IsNullOrWhiteSpace(val))
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNullOrWhiteSpace (Se Não Nulo ou Composto Apenas por Espaços em Branco)

        #region AreEquals (São iguais)

        /// <summary>
        /// Se o valor igual ao comparador, adiciona uma notificação (If the value is equal to the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreEquals(string val, string comparer, string message)
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
        public Contract<T> AreEquals(string val, string comparer, string key, string message)
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
        public Contract<T> AreNotEquals(string val, string comparer, string message)
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
        public Contract<T> AreNotEquals(string val, string comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }

        #endregion AreNotEquals (Não são iguais)

        #region Contains (Contém)

        /// <summary>
        /// Se o valor contém o comparador, adiciona uma notificação (If the value contains the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Contains(string val, string comparer, string message)
        {
            if (val.Contains(comparer))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor contém o comparador, adiciona uma notificação (If the value contains the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Contains(string val, string comparer, string key, string message)
        {
            if (val.Contains(comparer))
                AddNotification(key, message);

            return this;
        }

        #endregion Contains (Contém)

        #region NotContains (Não contém)

        /// <summary>
        /// Se o valor não contém o comparador, adiciona uma notificação (If the value does not contain the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> NotContains(string val, string comparer, string message)
        {
            if (!val.Contains(comparer))
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor não contém o comparador, adiciona uma notificação (If the value does not contain the comparer, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="comparer">O valor comparador (The comparer value).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> NotContains(string val, string comparer, string key, string message)
        {
            if (!val.Contains(comparer))
                AddNotification(key, message);

            return this;
        }

        #endregion NotContains (Não contém)

        #region IsGuid (Se for um Guid)

        /// <summary>
        /// Se o valor for um Guid válido, adiciona uma notificação (If the value is not a valid Guid, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsGuid(string val, string message)
        {
            if (Guid.TryParse(val, out _))
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
        public Contract<T> IsGuid(string val, string key, string message)
        {
            if (Guid.TryParse(val, out _))
                AddNotification(key, message);

            return this;
        }

        #endregion IsGuid (Se for um Guid)

        #region IsNotGuid (Se não for um Guid)

        /// <summary>
        /// Se o valor não for um Guid válido, adiciona uma notificação (If the value is not a valid Guid, add a notification).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotGuid(string val, string message)
        {
            if (!Guid.TryParse(val, out _))
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
        public Contract<T> IsNotGuid(string val, string key, string message)
        {
            if (!Guid.TryParse(val, out _))
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotGuid (Se não for um Guid)

        #region IsURL (Se for uma URL)

        /// <summary>
        /// Se o valor informado é uma URL válida (If the provided value is a valid URL).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsUrl(string val, string message) => Matches(val, NotificationCoreRegexPatterns.UrlRegexPattern, message);

        /// <summary>
        /// Se o valor informado é uma URL válida (If the provided value is a valid URL).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsUrl(string val, string key, string message) => Matches(val, NotificationCoreRegexPatterns.UrlRegexPattern, key, message);

        #endregion IsURL (Se for uma URL)

        #region IsNotURL (Se não for uma URL)

        /// <summary>
        /// Se o valor informado não é uma URL válida (If the provided value is not a valid URL).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotUrl(string val, string message) => NotMatches(val, NotificationCoreRegexPatterns.UrlRegexPattern, message);

        /// <summary>
        /// Se o valor informado não é uma URL válida (If the provided value is not a valid URL).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotUrl(string val, string key, string message) => NotMatches(val, NotificationCoreRegexPatterns.UrlRegexPattern, key, message);

        #endregion IsNotURL (Se não for uma URL)
    }
}
