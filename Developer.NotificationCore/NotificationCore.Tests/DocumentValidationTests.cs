using Developer.NotificationCore.Validations;

namespace Developer.NotificationCore.Tests;

public class DocumentValidationTests
{
    private static Contract<object> CreateSut() => new();

    /// <summary>
    /// Validate CPF (Cadastro de Pessoas Físicas) numbers. Validates both formatted and unformatted CPF numbers.
    /// </summary>
    /// <param name="cpf"></param>
    [Theory]
    [InlineData("529.982.247-25")]
    [InlineData("52998224725")]
    public void WhenCpfIsValidThenNoNotificationIsAdded(string cpf)
    {
        var sut = CreateSut().IsCPF(cpf, "msg");
        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Valida CPF (Cadastro de Pessoas Físicas) numbers. Validates both formatted and unformatted CPF numbers.
    /// </summary>
    /// <param name="cpf"></param>
    [Theory]
    [InlineData("529.982.247-26")]
    [InlineData("11111111111")]
    [InlineData("123")]
    [InlineData("")]
    [InlineData(null)]
    public void WhenCpfIsInvalidThenNotificationIsAdded(string? cpf)
    {
        var sut = CreateSut().IsCPF(cpf, "msg");
        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Valida CPF (Cadastro de Pessoas Físicas) numbers. Validates both formatted and unformatted CPF numbers.
    /// </summary>
    [Fact]
    public void WhenCpfIsInvalidWithKeyThenKeyIsUsed()
    {
        var sut = CreateSut().IsCPF("123", "Cpf", "msg");
        Assert.Equal("Cpf", Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Validate CNPJ (Cadastro Nacional da Pessoa Jurídica) numbers. Validates both formatted and unformatted CNPJ numbers.
    /// </summary>
    [Theory]
    [InlineData("11.222.333/0001-81")]
    [InlineData("11222333000181")]
    public void WhenCnpjIsValidThenNoNotificationIsAdded(string cnpj)
    {
        var sut = CreateSut().IsCNPJ(cnpj, "msg");
        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Valida CNPJ (Cadastro Nacional da Pessoa Jurídica) numbers. Validates both formatted and unformatted CNPJ numbers.
    /// </summary>
    /// <param name="cnpj"></param>
    [Theory]
    [InlineData("11.222.333/0001-82")]
    [InlineData("123")]
    [InlineData("")]
    [InlineData(null)]
    public void WhenCnpjIsInvalidThenNotificationIsAdded(string? cnpj)
    {
        var sut = CreateSut().IsCNPJ(cnpj, "msg");
        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Valida CNPJ (Cadastro Nacional da Pessoa Jurídica) numbers. Validates both formatted and unformatted CNPJ numbers.
    /// </summary>
    [Fact]
    public void WhenCnpjIsInvalidWithKeyThenKeyIsUsed()
    {
        var sut = CreateSut().IsCNPJ("123", "Cnpj", "msg");
        Assert.Equal("Cnpj", Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Valida cart�o de cr�dito (credit card) numbers. Validates both formatted and unformatted credit card numbers.
    /// </summary>
    /// <param name="card"></param>
    [Theory]
    [InlineData("4111111111111111")]
    [InlineData("4111 1111 1111 1111")]
    public void WhenCreditCardIsValidThenNoNotificationIsAdded(string card)
    {
        var sut = CreateSut().IsCreditCard(card, "msg");
        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Valida cart�o de cr�dito (credit card) numbers. Validates both formatted and unformatted credit card numbers.
    /// </summary>
    /// <param name="card"></param>
    [Theory]
    [InlineData("4111111111111112")]
    [InlineData("")]
    [InlineData(null)]
    public void WhenCreditCardIsInvalidThenNotificationIsAdded(string? card)
    {
        var sut = CreateSut().IsCreditCard(card, "msg");
        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Valida cart�o de cr�dito (credit card) numbers. Validates both formatted and unformatted credit card numbers.
    /// </summary>
    [Fact]
    public void WhenCreditCardIsInvalidWithKeyThenKeyIsUsed()
    {
        var sut = CreateSut().IsCreditCard("4111111111111112", "Card", "msg");
        Assert.Equal("Card", Assert.Single(sut.Notifications).Key);
    }
}
