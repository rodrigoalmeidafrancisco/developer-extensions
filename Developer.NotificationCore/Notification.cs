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
    }
}
