using Developer.NotificationCore.Validations;

namespace Developer.NotificationCore.Tests;

public class NotifiableTests
{
    private static Contract<object> CreateSut() => new();

    /// <summary>
    /// Verifica que sem notificações o objeto é válido.
    /// </summary>
    [Fact]
    public void WhenNoNotificationsThenIsValid()
    {
        var sut = CreateSut();

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que ao adicionar uma notificação o objeto deixa de ser válido.
    /// </summary>
    [Fact]
    public void WhenNotificationAddedThenIsNotValid()
    {
        var sut = CreateSut();

        sut.AddNotification("Name", "Required");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AddNotification com chave armazena a chave e a mensagem.
    /// </summary>
    [Fact]
    public void WhenAddNotificationWithKeyThenKeyAndMessageAreStored()
    {
        var sut = CreateSut();

        sut.AddNotification("Name", "Required");

        Assert.Equal(new Notification("Name", "Required"), Assert.Single(sut.Notifications));
    }

    /// <summary>
    /// Verifica que espaços no início e no fim da chave e da mensagem são removidos.
    /// </summary>
    [Fact]
    public void WhenAddNotificationWithPaddedTextThenTextIsTrimmed()
    {
        var sut = CreateSut();

        sut.AddNotification("  Name  ", "  Required  ");

        Assert.Equal(new Notification("Name", "Required"), Assert.Single(sut.Notifications));
    }

    /// <summary>
    /// Verifica que a mesma mensagem sem chave adicionada duas vezes é armazenada uma única vez.
    /// </summary>
    [Fact]
    public void WhenSameMessageAddedTwiceWithoutKeyThenOnlyOneIsStored()
    {
        var sut = CreateSut();

        sut.AddNotification("Required");
        sut.AddNotification("Required");

        Assert.Single(sut.Notifications);
    }

    /// <summary>
    /// Verifica que AddNotification com chave não evita duplicidade.
    /// </summary>
    [Fact]
    public void WhenSameKeyAndMessageAddedTwiceThenBothAreStored()
    {
        var sut = CreateSut();

        sut.AddNotification("Name", "Required");
        sut.AddNotification("Name", "Required");

        Assert.Equal(2, sut.Notifications.Count);
    }

    /// <summary>
    /// Verifica que AddNotification com um Type usa o nome do tipo como chave.
    /// </summary>
    [Fact]
    public void WhenAddNotificationWithTypeThenKeyIsTypeName()
    {
        var sut = CreateSut();

        sut.AddNotification(typeof(string), "Required");

        Assert.Equal("String", Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Verifica que AddNotification com Type nulo deixa a chave nula.
    /// </summary>
    [Fact]
    public void WhenAddNotificationWithNullTypeThenKeyIsNull()
    {
        var sut = CreateSut();

        sut.AddNotification((Type)null!, "Required");

        Assert.Null(Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Verifica que uma notificação já instanciada é armazenada.
    /// </summary>
    [Fact]
    public void WhenAddNotificationInstanceThenItIsStored()
    {
        var sut = CreateSut();
        var notification = new Notification("Name", "Required");

        sut.AddNotification(notification);

        Assert.Same(notification, Assert.Single(sut.Notifications));
    }

    /// <summary>
    /// Verifica que AddNotifications adiciona todos os itens de uma lista.
    /// </summary>
    [Fact]
    public void WhenAddNotificationsFromListThenAllAreStored()
    {
        var sut = CreateSut();
        IList<Notification> list = new List<Notification> { new("A", "1"), new("B", "2") };

        sut.AddNotifications(list);

        Assert.Equal(2, sut.Notifications.Count);
    }

    /// <summary>
    /// Verifica que AddNotifications adiciona todos os itens de uma coleção.
    /// </summary>
    [Fact]
    public void WhenAddNotificationsFromCollectionThenAllAreStored()
    {
        var sut = CreateSut();
        ICollection<Notification> collection = new HashSet<Notification> { new("A", "1"), new("B", "2") };

        sut.AddNotifications(collection);

        Assert.Equal(2, sut.Notifications.Count);
    }

    /// <summary>
    /// Verifica que AddNotifications adiciona todos os itens de uma coleção somente leitura.
    /// </summary>
    [Fact]
    public void WhenAddNotificationsFromReadOnlyCollectionThenAllAreStored()
    {
        var sut = CreateSut();
        IReadOnlyCollection<Notification> readOnly = new[] { new Notification("A", "1"), new Notification("B", "2") };

        sut.AddNotifications(readOnly);

        Assert.Equal(2, sut.Notifications.Count);
    }

    /// <summary>
    /// Verifica que as notificações de outro Notifiable são copiadas.
    /// </summary>
    [Fact]
    public void WhenAddNotificationsFromAnotherNotifiableThenItsNotificationsAreCopied()
    {
        var source = CreateSut();
        source.AddNotification("A", "1");
        var sut = CreateSut();

        sut.AddNotifications(source);

        Assert.Single(sut.Notifications);
    }

    /// <summary>
    /// Verifica que as notificações de vários Notifiable são copiadas.
    /// </summary>
    [Fact]
    public void WhenAddNotificationsFromMultipleNotifiablesThenAllAreCopied()
    {
        var first = CreateSut();
        first.AddNotification("A", "1");
        var second = CreateSut();
        second.AddNotification("B", "2");
        var sut = CreateSut();

        sut.AddNotifications(first, second);

        Assert.Equal(2, sut.Notifications.Count);
    }

    /// <summary>
    /// Verifica que um array nulo não adiciona nada nem lança exceção.
    /// </summary>
    [Fact]
    public void WhenAddNotificationsWithNullArrayThenNothingIsAdded()
    {
        var sut = CreateSut();

        sut.AddNotifications((Contract<object>[])null!);

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que Clear remove as notificações e torna o objeto válido.
    /// </summary>
    [Fact]
    public void WhenClearThenIsValid()
    {
        var sut = CreateSut();
        sut.AddNotification("A", "1");

        sut.Clear();

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que GetNotifications retorna apenas notificações distintas.
    /// </summary>
    [Fact]
    public void WhenDuplicatedNotificationsThenGetNotificationsReturnsDistinct()
    {
        var sut = CreateSut();
        sut.AddNotification("A", "1");
        sut.AddNotification("A", "1");

        Assert.Single(sut.GetNotifications());
    }

    /// <summary>
    /// Verifica que GetNotificationsMessages retorna apenas mensagens distintas.
    /// </summary>
    [Fact]
    public void WhenDuplicatedMessagesThenGetNotificationsMessagesReturnsDistinct()
    {
        var sut = CreateSut();
        sut.AddNotification("A", "Same");
        sut.AddNotification("B", "Same");

        Assert.Equal(new[] { "Same" }, sut.GetNotificationsMessages());
    }

    /// <summary>
    /// Verifica que GetNotificationsKeys retorna apenas chaves distintas.
    /// </summary>
    [Fact]
    public void WhenDuplicatedKeysThenGetNotificationsKeysReturnsDistinct()
    {
        var sut = CreateSut();
        sut.AddNotification("A", "1");
        sut.AddNotification("A", "2");

        Assert.Equal(new[] { "A" }, sut.GetNotificationsKeys());
    }

    /// <summary>
    /// Verifica que GetNotificationsKeys não lança exceção quando a chave é nula.
    /// </summary>
    [Fact]
    public void WhenNotificationHasNullKeyThenGetNotificationsKeysDoesNotThrow()
    {
        var sut = CreateSut();
        sut.AddNotification("Required");

        Assert.Equal(new string?[] { null }, sut.GetNotificationsKeys());
    }

    /// <summary>
    /// Verifica que GetNotifications não lança exceção quando a chave é nula.
    /// </summary>
    [Fact]
    public void WhenNotificationHasNullKeyThenGetNotificationsDoesNotThrow()
    {
        var sut = CreateSut();
        sut.AddNotification("Required");

        Assert.Single(sut.GetNotifications());
    }

    /// <summary>
    /// Verifica que GetNotificationsKeysAndMessages junta chave e mensagem.
    /// </summary>
    [Fact]
    public void WhenKeyAndMessageThenGetNotificationsKeysAndMessagesJoinsThem()
    {
        var sut = CreateSut();
        sut.AddNotification("Name", "Required");

        Assert.Equal(new[] { "Name: Required" }, sut.GetNotificationsKeysAndMessages());
    }
}
