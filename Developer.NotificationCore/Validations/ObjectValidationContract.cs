namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        #region IsNull (Se Nulo)

        /// <summary>
        /// Se o objeto for nulo, adiciona uma notificação (If the object is null, add a notification).
        /// </summary>
        /// <param name="val">O objeto a ser verificado (The object to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNull(object val, string message)
        {
            if (val == null)
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se o objeto for nulo, adiciona uma notificação (If the object is null, add a notification).
        /// </summary>
        /// <param name="val">O objeto a ser verificado (The object to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNull(object val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNull (Se Nulo)

        #region IsNotNull (Se Não Nulo)

        /// <summary>
        /// Se o objeto não for nulo, adiciona uma notificação (If the object is not null, add a notification).
        /// </summary>
        /// <param name="val">O objeto a ser verificado (The object to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(object val, string message)
        {
            if (val != null)
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se o objeto não for nulo, adiciona uma notificação (If the object is not null, add a notification).
        /// </summary>
        /// <param name="val">O objeto a ser verificado (The object to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(object val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        #endregion IsNotNull (Se Não Nulo)

        #region AreEquals (São iguais)

        /// <summary>
        /// Se os objetos forem iguais, adiciona uma notificação (If the objects are equal, add a notification).
        /// </summary>
        /// <param name="val">O primeiro objeto a ser comparado (The first object to be compared).</param>
        /// <param name="comparer">O segundo objeto a ser comparado (The second object to be compared).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreEquals(object val, object comparer, string message)
        {
            if (val == null || comparer == null)
                return this;

            if (val.Equals(comparer))
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se os objetos forem iguais, adiciona uma notificação (If the objects are equal, add a notification).
        /// </summary>
        /// <param name="val">O primeiro objeto a ser comparado (The first object to be compared).</param>
        /// <param name="comparer">O segundo objeto a ser comparado (The second object to be compared).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreEquals(object val, object comparer, string key, string message)
        {
            if (val == null || comparer == null)
                return this;

            if (val.Equals(comparer))
                AddNotification(key, message);

            return this;
        }

        #endregion AreEquals (São iguais)

        #region AreNotEquals (Não são iguais)

        /// <summary>
        /// Se os objetos forem diferentes, adiciona uma notificação (If the objects are different, add a notification).
        /// </summary>
        /// <param name="val">O primeiro objeto a ser comparado (The first object to be compared).</param>
        /// <param name="comparer">O segundo objeto a ser comparado (The second object to be compared).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(object val, object comparer, string message)
        {
            if (val == null || comparer == null)
                return this;

            if (!val.Equals(comparer))
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Se os objetos forem diferentes, adiciona uma notificação (If the objects are different, add a notification).
        /// </summary>
        /// <param name="val">O primeiro objeto a ser comparado (The first object to be compared).</param>
        /// <param name="comparer">O segundo objeto a ser comparado (The second object to be compared).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(object val, object comparer, string key, string message)
        {
            if (val == null || comparer == null)
                return this;

            if (!val.Equals(comparer))
                AddNotification(key, message);

            return this;
        }

        #endregion AreNotEquals (Não são iguais)
    }
}
