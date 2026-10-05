using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Developer.NotificationCore
{
    public abstract class Notifiable<T> where T : Notification // Classe abstrata genérica, restrita a tipos derivados de Notification
    {
        protected Notifiable()
        {
            // Inicializa a lista interna de notificações vazia
            _notifications = new List<T>();
        }

        [NotMapped] // Indica que a propriedade não deve ser mapeada para uma coluna de banco de dados
        [JsonIgnore] // Impede que o campo seja serializado em JSON
        [IgnoreDataMember] // Impede que o campo seja serializado por outros serializadores (ex: DataContract)
        private readonly List<T> _notifications; // Lista interna somente leitura que armazena as notificações

        [NotMapped] // Indica que a propriedade não deve ser mapeada para uma coluna de banco de dados
        [JsonIgnore] // Impede que a propriedade seja serializada em JSON
        [IgnoreDataMember] // Impede que a propriedade seja serializada por outros serializadores
        public IReadOnlyCollection<T> Notifications => _notifications; // Expõe a lista interna como coleção somente leitura

        [NotMapped] // Indica que a propriedade não deve ser mapeada para uma coluna de banco de dados
        [JsonIgnore] // Impede que a propriedade seja serializada em JSON
        [IgnoreDataMember] // Impede que a propriedade seja serializada por outros serializadores
        public bool IsValid => _notifications.Count == 0; // Retorna true quando não há notificações (ou seja, válido)

        #region Methods // Início da região que agrupa os métodos da classe

        /// <summary>
        /// Cria uma instância de T invocando seu construtor que aceita uma chave e uma mensagem. 
        /// </summary>
        /// <remarks>Utiliza Activator.CreateInstance e pode lançar exceções como MissingMethodException
        /// ou TargetInvocationException se um construtor correspondente não for encontrado ou se o construtor lançar uma exceção.</remarks>
        /// <param name="key">Identificador passado para o construtor do tipo de destino.</param>
        /// <param name="message">Mensagem passada para o construtor do tipo de destino.</param>
        /// <returns>Uma nova instância de T inicializada com a chave e a mensagem fornecidas.</returns>
        private T CreateNotificationInstance(string key, string message)
        {
            // Instancia T passando chave e mensagem ao construtor
            return (T)Activator.CreateInstance(typeof(T), new object[] { key, message });
        }

        /// <summary>
        /// Retorna uma lista de notificações distintas, cada uma representando uma combinação única de chave e mensagem.
        /// </summary>
        /// <returns>Uma List<Notification> contendo notificações únicas, na ordem de sua primeira ocorrência.</returns>
        public List<Notification> GetNotifications()
        {
            // Cria novas instâncias de Notification com chave e mensagem, remove duplicadas e converte para lista
            return _notifications.Select(n => new Notification(n.Key?.Trim(), n.Message?.Trim())).Distinct().ToList();
        }

        /// <summary>
        /// Retorna uma lista de mensagens de notificação distintas. 
        /// </summary>
        /// <remarks>A exclusividade é determinada usando o comparador de igualdade de strings padrão.</remarks>
        /// <returns>Uma List<string> contendo mensagens de notificação únicas, na ordem de sua primeira ocorrência.</returns>
        public List<string> GetNotificationsMessages()
        {
            // Seleciona as mensagens, remove duplicadas e converte para lista
            return _notifications.Select(n => n.Message?.Trim()).Distinct().ToList();
        }

        /// <summary>
        /// Retorna uma lista de chaves de notificação distintas.
        /// </summary>
        /// <returns>Uma List<string> contendo chaves de notificação únicas, na ordem de sua primeira ocorrência.</returns>
        public List<string> GetNotificationsKeys()
        {
            // Seleciona as chaves, remove duplicadas e converte para lista
            return _notifications.Select(n => n.Key?.Trim()).Distinct().ToList();
        }

        /// <summary>
        /// Retorna uma lista de strings que combinam a chave e a mensagem de cada notificação, garantindo que cada combinação seja única.
        /// </summary>
        /// <returns>Uma List<string> contendo combinações únicas de chave e mensagem.</returns>
        public List<string> GetNotificationsKeysAndMessages()
        {
            // Combina chave e mensagem, remove duplicadas e converte para lista
            return _notifications.Select(n => $"{n.Key?.Trim()}: {n.Message?.Trim()}").Distinct().ToList();
        }


        /// <summary>
        /// Adiciona uma notificação apenas com mensagem (sem chave).
        /// </summary>
        /// <param name="message">A mensagem da notificação.</param>
        /// <remarks>Se a notificação já existir na lista interna, ela não será adicionada novamente.</remarks>
        public void AddNotification(string message)
        {
            // Cria a notificação com chave nula
            var notification = CreateNotificationInstance(null, message?.Trim());

            // Verifica se a notificação já não existe na lista
            if (!_notifications.Contains(notification))
            {
                // Adiciona a notificação à lista, evitando duplicatas
                _notifications.Add(notification);
            }
        }

        /// <summary>
        /// Adiciona uma notificação com chave e mensagem. Não verifica duplicidade, permitindo múltiplas notificações com a mesma chave e mensagem.
        /// </summary>
        /// <param name="key">A chave da notificação.</param>
        /// <param name="message">A mensagem da notificação.</param>
        /// <remarks>Se a notificação já existir na lista interna, ela será adicionada novamente.</remarks>
        public void AddNotification(string key, string message)
        {
            // Cria a notificação com a chave e mensagem informadas
            var notification = CreateNotificationInstance(key?.Trim(), message?.Trim());
            // Adiciona a notificação à lista sem verificar duplicidade
            _notifications.Add(notification);
        }

        /// <summary>
        /// Adiciona uma notificação já instanciada diretamente.
        /// </summary>
        /// <param name="notification">O objeto de notificação a ser adicionado.</param>
        /// <remarks>Se a notificação já existir na lista interna, ela será adicionada novamente.</remarks>
        public void AddNotification(T notification)
        {
            // Adiciona o objeto de notificação recebido à lista
            _notifications.Add(notification);
        }

        /// <summary>
        /// Adiciona uma notificação usando o nome de um tipo como chave. A chave será o nome do tipo fornecido, e a mensagem será a mensagem informada.
        /// </summary>
        /// <param name="property">O tipo cuja nome será usado como chave da notificação.</param>
        /// <param name="message">A mensagem da notificação.</param>
        /// <remarks>Se a notificação já existir na lista interna, ela será adicionada novamente.</remarks>
        public void AddNotification(Type property, string message)
        {
            // Cria a notificação usando o nome do tipo (ou nulo) como chave
            var notification = CreateNotificationInstance(property?.Name, message?.Trim());
            // Adiciona a notificação criada à lista
            _notifications.Add(notification);
        }

        /// <summary>
        /// Adiciona um conjunto de notificações a partir de uma coleção somente leitura. As notificações existentes na lista interna não serão verificadas quanto à duplicidade.
        /// </summary>
        /// <param name="notifications">A coleção de notificações a ser adicionada.</param>
        /// <remarks>Se as notificações já existirem na lista interna, elas serão adicionadas novamente.</remarks>
        public void AddNotifications(IReadOnlyCollection<T> notifications)
        {
            // Insere todas as notificações recebidas na lista interna
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// Adiciona um conjunto de notificações a partir de uma lista. As notificações existentes na lista interna não serão verificadas quanto à duplicidade.
        /// </summary>
        /// <param name="notifications">A lista de notificações a ser adicionada.</param>
        /// <remarks>Se as notificações já existirem na lista interna, elas serão adicionadas novamente.</remarks>
        public void AddNotifications(IList<T> notifications)
        {
            // Insere todas as notificações recebidas na lista interna
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// Adiciona um conjunto de notificações a partir de uma coleção genérica. As notificações existentes na lista interna não serão verificadas quanto à duplicidade.
        /// </summary>
        /// <param name="notifications">A coleção de notificações a ser adicionada.</param>
        /// <remarks>Se as notificações já existirem na lista interna, elas serão adicionadas novamente.</remarks>
        public void AddNotifications(ICollection<T> notifications)
        {
            // Insere todas as notificações recebidas na lista interna
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// Adiciona as notificações de outro objeto Notifiable. As notificações existentes na lista interna não serão verificadas quanto à duplicidade.
        /// </summary>
        /// <param name="item">O objeto Notifiable cujas notificações serão adicionadas.</param>
        /// <remarks>Se as notificações já existirem na lista interna, elas serão adicionadas novamente.</remarks>
        public void AddNotifications(Notifiable<T> item)
        {
            // Reaproveita o método para adicionar as notificações do item informado
            AddNotifications(item.Notifications);
        }

        /// <summary>
        /// Adiciona as notificações de vários objetos Notifiable passados como parâmetros. As notificações existentes na lista interna não serão verificadas quanto à duplicidade.
        /// </summary>
        /// <param name="items">Os objetos Notifiable cujas notificações serão adicionadas.</param>
        /// <remarks>Se as notificações já existirem na lista interna, elas serão adicionadas novamente.</remarks>
        public void AddNotifications(params Notifiable<T>[] items)
        {
            // Verifica se o array não é nulo e contém elementos
            if (items != null && items.Length > 0)
            {
                // Itera sobre cada item do array
                foreach (var item in items)
                {
                    // Adiciona as notificações do item atual à lista interna
                    AddNotifications(item);
                }
            }
        }

        /// <summary>
        /// Limpa todas as notificações existentes na lista interna, removendo todas as entradas.
        /// </summary>
        /// <remarks>Após a execução deste método, a lista interna de notificações estará vazia.</remarks>
        public void Clear()
        {
            // Limpa completamente a lista interna de notificações
            _notifications.Clear();
        }

        #endregion Methods // Fim da região de métodos
    }
}


