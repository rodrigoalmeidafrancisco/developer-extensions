using Developer.NotificationCore.Validations;

namespace Developer.NotificationCore.Tests;

public class ContractTests
{
    private static Contract<object> CreateSut() => new();

    /// <summary>
    /// Verifica que Requires retorna a própria instância para permitir encadeamento.
    /// </summary>
    [Fact]
    public void WhenRequiresThenReturnsSameInstance()
    {
        var sut = CreateSut();
        Assert.Same(sut, sut.Requires());
    }

    /// <summary>
    /// Verifica que Join copia as notificações de um Notifiable inválido.
    /// </summary>
    [Fact]
    public void WhenJoinNotifiableIsInvalidThenNotificationsAreCopied()
    {
        var other = CreateSut();
        other.AddNotification("A", "1");
        var sut = CreateSut();

        sut.Join(other);

        Assert.Single(sut.Notifications);
    }

    /// <summary>
    /// Verifica que Join não adiciona nada quando o Notifiable é válido.
    /// </summary>
    [Fact]
    public void WhenJoinNotifiableIsValidThenNothingIsAdded()
    {
        var sut = CreateSut();

        sut.Join(CreateSut());

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que Join com array nulo não adiciona nada nem lança exceção.
    /// </summary>
    [Fact]
    public void WhenJoinArrayIsNullThenNothingIsAdded()
    {
        var sut = CreateSut();

        sut.Join(null!);

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNull para string notifica somente quando o valor é nulo.
    /// </summary>
    [Theory]
    [InlineData(null, true)]
    [InlineData("a", false)]
    public void WhenStringIsNullThenNotificationIsAdded(string? value, bool expectedNotification)
    {
        var sut = CreateSut().IsNull(value, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNullOrEmpty notifica para nulo e vazio, mas não para espaços.
    /// </summary>
    [Theory]
    [InlineData(null, true)]
    [InlineData("", true)]
    [InlineData(" ", false)]
    [InlineData("a", false)]
    public void WhenStringIsNullOrEmptyThenNotificationIsAdded(string? value, bool expectedNotification)
    {
        var sut = CreateSut().IsNullOrEmpty(value, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNullOrWhiteSpace notifica para nulo, vazio e apenas espaços.
    /// </summary>
    [Theory]
    [InlineData(null, true)]
    [InlineData("", true)]
    [InlineData("   ", true)]
    [InlineData("a", false)]
    public void WhenStringIsNullOrWhiteSpaceThenNotificationIsAdded(string? value, bool expectedNotification)
    {
        var sut = CreateSut().IsNullOrWhiteSpace(value, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNull para string usa a chave informada.
    /// </summary>
    [Fact]
    public void WhenStringIsNullWithKeyThenKeyIsUsed()
    {
        var sut = CreateSut().IsNull((string?)null, "Name", "msg");

        Assert.Equal("Name", Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Verifica que IsNotNull para string notifica somente quando o valor não é nulo.
    /// </summary>
    [Theory]
    [InlineData(null, false)]
    [InlineData("a", true)]
    public void WhenStringIsNotNullThenNotificationIsAdded(string? value, bool expectedNotification)
    {
        var sut = CreateSut().IsNotNull(value, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsGreaterThan para int notifica somente quando o valor é maior.
    /// </summary>
    [Theory]
    [InlineData(5, 3, true)]
    [InlineData(3, 3, false)]
    [InlineData(1, 3, false)]
    public void WhenIntIsGreaterThanComparerThenNotificationIsAdded(int value, int comparer, bool expectedNotification)
    {
        var sut = CreateSut().IsGreaterThan(value, comparer, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsGreaterOrEqualsThan para int notifica quando o valor é maior ou igual.
    /// </summary>
    [Theory]
    [InlineData(5, 3, true)]
    [InlineData(3, 3, true)]
    [InlineData(1, 3, false)]
    public void WhenIntIsGreaterOrEqualsThanComparerThenNotificationIsAdded(int value, int comparer, bool expectedNotification)
    {
        var sut = CreateSut().IsGreaterOrEqualsThan(value, comparer, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsLowerThan para int notifica somente quando o valor é menor.
    /// </summary>
    [Theory]
    [InlineData(1, 3, true)]
    [InlineData(3, 3, false)]
    [InlineData(5, 3, false)]
    public void WhenIntIsLowerThanComparerThenNotificationIsAdded(int value, int comparer, bool expectedNotification)
    {
        var sut = CreateSut().IsLowerThan(value, comparer, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsFalse notifica quando o valor é falso.
    /// </summary>
    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void WhenBoolIsFalseThenNotificationIsAdded(bool value, bool expectedNotification)
    {
        var sut = CreateSut().IsFalse(value, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsTrue notifica quando o valor é verdadeiro.
    /// </summary>
    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void WhenBoolIsTrueThenNotificationIsAdded(bool value, bool expectedNotification)
    {
        var sut = CreateSut().IsTrue(value, "msg");

        Assert.Equal(expectedNotification, !sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNull para object notifica quando o objeto é nulo.
    /// </summary>
    [Fact]
    public void WhenObjectIsNullThenNotificationIsAdded()
    {
        var sut = CreateSut().IsNull((object?)null, "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNull para object não notifica quando o objeto não é nulo.
    /// </summary>
    [Fact]
    public void WhenObjectIsNotNullThenIsNullDoesNotAddNotification()
    {
        var sut = CreateSut().IsNull(new object(), "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AreEquals notifica quando os objetos são iguais.
    /// </summary>
    [Fact]
    public void WhenObjectsAreEqualThenAreEqualsAddsNotification()
    {
        var sut = CreateSut().AreEquals("a", "a", "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AreEquals não notifica quando os objetos são diferentes.
    /// </summary>
    [Fact]
    public void WhenObjectsAreDifferentThenAreEqualsDoesNotAddNotification()
    {
        var sut = CreateSut().AreEquals("a", "b", "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AreEquals não notifica quando um dos objetos é nulo.
    /// </summary>
    [Fact]
    public void WhenObjectIsNullThenAreEqualsDoesNotAddNotification()
    {
        var sut = CreateSut().AreEquals(null!, "b", "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AreNotEquals notifica quando os objetos são diferentes.
    /// </summary>
    [Fact]
    public void WhenObjectsAreDifferentThenAreNotEqualsAddsNotification()
    {
        var sut = CreateSut().AreNotEquals("a", "b", "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AreNotEquals não notifica quando os objetos são iguais.
    /// </summary>
    [Fact]
    public void WhenObjectsAreEqualThenAreNotEqualsDoesNotAddNotification()
    {
        var sut = CreateSut().AreNotEquals("a", "a", "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que AreEquals para Guid notifica quando os valores são iguais.
    /// </summary>
    [Fact]
    public void WhenGuidsAreEqualThenAreEqualsAddsNotification()
    {
        var id = Guid.NewGuid();

        var sut = CreateSut().AreEquals(id, id, "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNull para Guid notifica quando o valor é nulo.
    /// </summary>
    [Fact]
    public void WhenGuidIsNullThenIsNullAddsNotification()
    {
        var sut = CreateSut().IsNull((Guid?)null, "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNull para lista notifica quando a lista é nula.
    /// </summary>
    [Fact]
    public void WhenListIsNullThenIsNullAddsNotification()
    {
        var sut = CreateSut().IsNull<int>(null!, "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsEmpty notifica quando a lista está vazia.
    /// </summary>
    [Fact]
    public void WhenListIsEmptyThenIsEmptyAddsNotification()
    {
        var sut = CreateSut().IsEmpty(new List<int>(), "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsEmpty não notifica quando a lista tem itens.
    /// </summary>
    [Fact]
    public void WhenListHasItemsThenIsEmptyDoesNotAddNotification()
    {
        var sut = CreateSut().IsEmpty(new List<int> { 1 }, "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsNotEmpty notifica quando a lista tem itens.
    /// </summary>
    [Fact]
    public void WhenListIsNotEmptyThenIsNotEmptyAddsNotification()
    {
        var sut = CreateSut().IsNotEmpty(new List<int> { 1 }, "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsGreaterThan para DateTime notifica quando a data é maior.
    /// </summary>
    [Fact]
    public void WhenDateIsGreaterThanComparatorThenNotificationIsAdded()
    {
        var sut = CreateSut().IsGreaterThan(new DateTime(2025, 1, 2), new DateTime(2025, 1, 1), "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que IsGreaterThan para DateTime não notifica quando a data não é maior.
    /// </summary>
    [Fact]
    public void WhenDateIsNotGreaterThanComparatorThenNoNotificationIsAdded()
    {
        var sut = CreateSut().IsGreaterThan(new DateTime(2025, 1, 1), new DateTime(2025, 1, 2), "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que validações encadeadas acumulam todas as notificações geradas.
    /// </summary>
    [Fact]
    public void WhenChainedValidationsFailThenAllNotificationsAreCollected()
    {
        var sut = CreateSut()
            .IsNullOrWhiteSpace("", "Name", "name")
            .IsNull((string?)null, "Email", "email");

        Assert.Equal(2, sut.Notifications.Count);
    }
}
