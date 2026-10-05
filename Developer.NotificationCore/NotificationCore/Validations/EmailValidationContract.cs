using Developer.NotificationCore.Patterns;

namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Valida se o valor informado é um e-mail válido (Validates if the provided value is a valid email).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsEmail(string val, string message)
        {
            return Matches(val, NotificationCoreRegexPatterns.EmailRegexPattern, message);
        }

        /// <summary>
        /// Valida se o valor informado é um e-mail válido (Validates if the provided value is a valid email).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsEmail(string val, string key, string message)
        {
            return Matches(val, NotificationCoreRegexPatterns.EmailRegexPattern, key, message);
        }

        /// <summary>
        /// Valida se o valor informado é um e-mail válido ou vazio (Validates if the provided value is a valid email or empty).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsEmailOrEmpty(string val, string message)
        {
            return string.IsNullOrEmpty(val) ? this : IsEmail(val, message);
        }

        /// <summary>
        /// Valida se o valor informado é um e-mail válido ou vazio (Validates if the provided value is a valid email or empty).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsEmailOrEmpty(string val, string key, string message)
        {
            return string.IsNullOrEmpty(val) ? this : IsEmail(val, key, message);
        }

        /// <summary>
        /// Valida se o valor informado não é um e-mail válido (Validates if the provided value is not a valid email).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotEmail(string val, string message)
        {
            return NotMatches(val, NotificationCoreRegexPatterns.EmailRegexPattern, message);
        }

        /// <summary>
        /// Valida se o valor informado não é um e-mail válido (Validates if the provided value is not a valid email).
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotEmail(string val, string key, string message)
        {
            return NotMatches(val, NotificationCoreRegexPatterns.EmailRegexPattern, key, message);
        }

    }
}
