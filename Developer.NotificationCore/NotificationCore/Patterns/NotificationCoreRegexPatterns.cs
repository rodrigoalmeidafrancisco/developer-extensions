namespace Developer.NotificationCore.Patterns
{
    public static class NotificationCoreRegexPatterns
    {
        /// <summary>
        /// Padrão de expressão regular para validar endereços de e-mail.
        /// </summary>
        public const string EmailRegexPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        /// <summary>
        /// Padrão de expressão regular para validar URLs.
        /// </summary>
        public const string UrlRegexPattern = @"^(http|https):(\/\/www\.|\/\/www\.|\/\/|\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$|(http|https):(\/\/localhost:\d*|\/\/127\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\/.*)?$";
        /// <summary>
        /// Padrão de expressão regular para validar apenas números.
        /// </summary>
        public const string OnlyNumbersPattern = @"[^0-9]+";
        /// <summary>
        /// Padrão de expressão regular para validar apenas letras e números.
        /// </summary>
        public const string OnlyLettersAndNumbersPattern = @"[A-Za-z0-9_-]";
        /// <summary>
        /// Padrão de expressão regular para validar passaportes.
        /// </summary>
        public const string PassportRegexPattern = @"^(?!^0+$)[a-zA-Z0-9]{3,20}$";
    }
}
