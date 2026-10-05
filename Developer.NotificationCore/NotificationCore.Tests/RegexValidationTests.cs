using Developer.NotificationCore.Patterns;
using Developer.NotificationCore.Validations;

namespace Developer.NotificationCore.Tests;

public class RegexValidationTests
{
    private static Contract<object> CreateSut() => new();

    /// <summary>
    /// Verifica que Matches adiciona notificação quando o valor casa com o padrão.
    /// </summary>
    [Fact]
    public void WhenValueMatchesPatternThenMatchesAddsNotification()
    {
        var sut = CreateSut().Matches("abc", "^a", "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que Matches não adiciona notificação quando o valor não casa com o padrão.
    /// </summary>
    [Fact]
    public void WhenValueDoesNotMatchPatternThenMatchesAddsNoNotification()
    {
        var sut = CreateSut().Matches("xyz", "^a", "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que Matches trata valor nulo como string vazia.
    /// </summary>
    [Fact]
    public void WhenValueIsNullThenMatchesUsesEmptyString()
    {
        var sut = CreateSut().Matches(null!, "^$", "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que NotMatches adiciona notificação quando o valor não casa com o padrão.
    /// </summary>
    [Fact]
    public void WhenValueDoesNotMatchPatternThenNotMatchesAddsNotification()
    {
        var sut = CreateSut().NotMatches("xyz", "^a", "msg");

        Assert.False(sut.IsValid);
    }

    /// <summary>
    /// Verifica que NotMatches não adiciona notificação quando o valor casa com o padrão.
    /// </summary>
    [Fact]
    public void WhenValueMatchesPatternThenNotMatchesAddsNoNotification()
    {
        var sut = CreateSut().NotMatches("abc", "^a", "msg");

        Assert.True(sut.IsValid);
    }

    /// <summary>
    /// Verifica que Matches usa a chave informada na notificação.
    /// </summary>
    [Fact]
    public void WhenMatchesWithKeyThenKeyIsUsed()
    {
        var sut = CreateSut().Matches("abc", "^a", "Field", "msg");

        Assert.Equal("Field", Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Verifica que NotMatches usa a chave informada na notificação.
    /// </summary>
    [Fact]
    public void WhenNotMatchesWithKeyThenKeyIsUsed()
    {
        var sut = CreateSut().NotMatches("xyz", "^a", "Field", "msg");

        Assert.Equal("Field", Assert.Single(sut.Notifications).Key);
    }

    /// <summary>
    /// Verifica que o padrão de e-mail casa apenas com e-mails válidos.
    /// </summary>
    [Theory]
    [InlineData("user@example.com", true)]
    [InlineData("not-an-email", false)]
    public void WhenEmailPatternIsAppliedThenOnlyValidEmailsMatch(string value, bool expectedMatch)
    {
        Assert.Equal(expectedMatch, System.Text.RegularExpressions.Regex.IsMatch(value, NotificationCoreRegexPatterns.EmailRegexPattern));
    }

    /// <summary>
    /// Verifica que o padrão de URL casa apenas com URLs válidas.
    /// </summary>
    [Theory]
    [InlineData("https://www.example.com/path", true)]
    [InlineData("http://localhost:5000", true)]
    [InlineData("example.com", false)]
    public void WhenUrlPatternIsAppliedThenOnlyValidUrlsMatch(string value, bool expectedMatch)
    {
        Assert.Equal(expectedMatch, System.Text.RegularExpressions.Regex.IsMatch(value, NotificationCoreRegexPatterns.UrlRegexPattern));
    }

    /// <summary>
    /// Verifica que o padrão de passaporte casa apenas com passaportes válidos.
    /// </summary>
    [Theory]
    [InlineData("AB123456", true)]
    [InlineData("000000", false)]
    [InlineData("A1", false)]
    public void WhenPassportPatternIsAppliedThenOnlyValidPassportsMatch(string value, bool expectedMatch)
    {
        Assert.Equal(expectedMatch, System.Text.RegularExpressions.Regex.IsMatch(value, NotificationCoreRegexPatterns.PassportRegexPattern));
    }

    /// <summary>
    /// Verifica que o padrão de apenas números remove os caracteres não numéricos.
    /// </summary>
    [Fact]
    public void WhenOnlyNumbersPatternIsReplacedThenNonDigitsAreRemoved()
    {
        var result = System.Text.RegularExpressions.Regex.Replace("a1-b2.3", NotificationCoreRegexPatterns.OnlyNumbersPattern, "");

        Assert.Equal("123", result);
    }
}
