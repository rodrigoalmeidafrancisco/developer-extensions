namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        #region IsFalse

        /// <summary>
        /// Se o valor for falso, adiciona uma notificação (If the value is false, add a notification).
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsFalse(bool val, string message)
        {
            if (val == false)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for falso, adiciona uma notificação (If the value is false, add a notification).
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="key">Nome da chave ou propriedade (Name of the key or property)</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsFalse(bool val, string key, string message)
        {
            if (val == false)
                AddNotification(key, message);

            return this;
        }

        #endregion IsFalse

        #region IsTrue

        /// <summary>
        /// Se o valor for verdadeiro, adiciona uma notificação (If the value is true, add a notification).
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsTrue(bool val, string message)
        {
            if (val == true)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for verdadeiro, adiciona uma notificação (If the value is true, add a notification).
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="key">Nome da chave ou propriedade (Name of the key or property)</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsTrue(bool val, string key, string message)
        {
            if (val == true)
                AddNotification(key, message);

            return this;
        }

        #endregion IsTrue

        #region IsNull

        /// <summary>
        /// Se o valor for nulo, adiciona uma notificação (If the value is null, add a notification).
        /// </summary>
        /// <param name="val">bool?</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsNull(bool? val, string message)
        {
            if (val == null)
                AddNotification((string)null, message);

            return this;
        }

        /// <summary>
        /// Se o valor for nulo, adiciona uma notificação (If the value is null, add a notification).
        /// </summary>
        /// <param name="val">bool?</param>
        /// <param name="key">Nome da chave ou propriedade (Name of the key or property)</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsNull(bool? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNull

        #region IsNotNull

        /// <summary>
        /// Se o valor não for nulo, adiciona uma notificação (If the value is not null, add a notification).
        /// </summary>
        /// <param name="val">bool?</param>
        /// <param name="key">Nome da chave ou propriedade (Name of the key or property)</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(bool? val, string message)
        {
            if (val != null)
                AddNotification((string)null, message);

            return this;
        }


        /// <summary>
        /// Se o valor não for nulo, adiciona uma notificação (If the value is not null, add a notification).
        /// </summary>
        /// <param name="val">bool?</param>
        /// <param name="key">Nome da chave ou propriedade (Name of the key or property)</param>
        /// <param name="message">Mensagem de erro personalizada (Custom error message)</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(bool? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNull

    }
}
