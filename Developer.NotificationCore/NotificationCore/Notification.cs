using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Developer.NotificationCore
{
    public class Notification
    {
        public Notification()
        {

        }

        public Notification(string message)
        {
            Key = null;
            Message = message;
        }

        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
        }

        [NotMapped] // Indica que a propriedade não deve ser mapeada para uma coluna de banco de dados
        [JsonIgnore] // Impede que o campo seja serializado em JSON
        [IgnoreDataMember] // Impede que o campo seja serializado por outros serializadores (ex: DataContract)
        public string Key { get; set; }

        [NotMapped] // Indica que a propriedade não deve ser mapeada para uma coluna de banco de dados
        [JsonIgnore] // Impede que o campo seja serializado em JSON
        [IgnoreDataMember] // Impede que o campo seja serializado por outros serializadores (ex: DataContract)
        public string Message { get; set; }

        /// <summary>
        /// Duas notificações são iguais quando possuem a mesma chave e a mesma mensagem.
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Notification other
                && string.Equals(Key, other.Key, System.StringComparison.Ordinal)
                && string.Equals(Message, other.Message, System.StringComparison.Ordinal);
        }

        /// <summary>
        /// Gera o hash a partir da chave e da mensagem, consistente com <see cref="Equals(object)"/>.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Key?.GetHashCode() ?? 0) * 397) ^ (Message?.GetHashCode() ?? 0);
            }
        }
    }
}
