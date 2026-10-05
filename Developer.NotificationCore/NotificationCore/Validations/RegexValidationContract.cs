using System.Text.RegularExpressions;

namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Exige que uma string corresponda a um padrão de expressão regular. (Requires a string matches a regex pattern)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="pattern">O padrão de expressão regular (The regex pattern).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Matches(string val, string pattern, string message)
        {
            if (Regex.IsMatch(val ?? "", pattern))
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Exige que uma string corresponda a um padrão de expressão regular. (Requires a string matches a regex pattern)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="pattern">O padrão de expressão regular (The regex pattern).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> Matches(string val, string pattern, string key, string message)
        {
            if (Regex.IsMatch(val ?? "", pattern))
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Exige que uma string não corresponda a um padrão de expressão regular. (Requires a string not matches a regex pattern)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="pattern">O padrão de expressão regular (The regex pattern).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> NotMatches(string val, string pattern, string message)
        {
            if (!Regex.IsMatch(val ?? "", pattern))
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Exige que uma string não corresponda a um padrão de expressão regular. (Requires a string not matches a regex pattern)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="pattern">O padrão de expressão regular (The regex pattern).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> NotMatches(string val, string pattern, string key, string message)
        {
            if (!Regex.IsMatch(val ?? "", pattern))
                AddNotification(key, message);

            return this;
        }
    }
}
