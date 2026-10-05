namespace Developer.NotificationCore.Tests;

public class NotificationTests
{
    /// <summary>
    /// Verifica que duas notificações com a mesma chave e mensagem são consideradas iguais.
    /// </summary>
    [Fact]
    public void WhenKeyAndMessageAreEqualThenNotificationsAreEqual()
    {
        var first = new Notification("Name", "Required");
        var second = new Notification("Name", "Required");

        Assert.Equal(first, second);
    }

    /// <summary>
    /// Verifica que notificações iguais geram o mesmo hash code.
    /// </summary>
    [Fact]
    public void WhenKeyAndMessageAreEqualThenHashCodesAreEqual()
    {
        var first = new Notification("Name", "Required");
        var second = new Notification("Name", "Required");

        Assert.Equal(first.GetHashCode(), second.GetHashCode());
    }

    /// <summary>
    /// Verifica que notificações com chaves diferentes não são iguais.
    /// </summary>
    [Fact]
    public void WhenKeysDifferThenNotificationsAreNotEqual()
    {
        var first = new Notification("Name", "Required");
        var second = new Notification("Email", "Required");

        Assert.NotEqual(first, second);
    }

    /// <summary>
    /// Verifica que notificações com mensagens diferentes não são iguais.
    /// </summary>
    [Fact]
    public void WhenMessagesDifferThenNotificationsAreNotEqual()
    {
        var first = new Notification("Name", "Required");
        var second = new Notification("Name", "Invalid");

        Assert.NotEqual(first, second);
    }

    /// <summary>
    /// Verifica que notificações sem chave e com a mesma mensagem são iguais.
    /// </summary>
    [Fact]
    public void WhenKeysAreBothNullThenNotificationsAreEqual()
    {
        var first = new Notification("Required");
        var second = new Notification("Required");

        Assert.Equal(first, second);
    }

    /// <summary>
    /// Verifica que uma notificação nunca é igual a nulo.
    /// </summary>
    [Fact]
    public void WhenComparedWithNullThenNotificationsAreNotEqual()
    {
        var notification = new Notification("Name", "Required");

        Assert.False(notification.Equals(null));
    }

    /// <summary>
    /// Verifica que o construtor apenas com mensagem deixa a chave nula.
    /// </summary>
    [Fact]
    public void WhenCreatedWithOnlyMessageThenKeyIsNull()
    {
        var notification = new Notification("Required");

        Assert.Null(notification.Key);
    }

    /// <summary>
    /// Verifica que o construtor com chave e mensagem define a mensagem.
    /// </summary>
    [Fact]
    public void WhenCreatedWithKeyAndMessageThenMessageIsSet()
    {
        var notification = new Notification("Name", "Required");

        Assert.Equal("Required", notification.Message);
    }
}
