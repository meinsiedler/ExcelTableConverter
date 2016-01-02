using System.Globalization;
using System.Threading;
using NUnit.Framework;

namespace ExcelTableConverter.Utilities.Tests
{
  [TestFixture]
  public class StringExtensionsTests
  {
    [Test]
    public void IsNumeric_PositiveNumber_ReturnsTrue()
    {
      var result = "1234".IsNumericCurrentCulture();
      Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsNumeric_NegativeNumber_ReturnsTrue()
    {
      var result = "-1234".IsNumericCurrentCulture();
      Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsNumeric_PositiveDecimalNumberEN_ReturnsTrue()
    {
      var result = "1.234".IsNumericCurrentCulture();
      Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsNumeric_PositiveDecimalNumberDE_ReturnsTrue()
    {
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
      var result = "1,234".IsNumericCurrentCulture();
      Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsNumeric_PositiveDecimalNumberWithTousandSeperatorEN_ReturnsTrue()
    {
      var result = "1,234.5".IsNumeric(CultureInfo.GetCultureInfo("en-US"));
      Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsNumeric_PositiveDecimalNumberWithTousandSeperatorDE_ReturnsTrue()
    {
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
      var result = "1.234,5".IsNumericCurrentCulture();
      Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IsNumeric_WithBlankBetweenTwoNumbers_ReturnsTrue()
    {
      // note that culture "de-AT" thinks that "1 1" is numeric (returns 11.0)
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
      Assert.That("1 1".IsNumericCurrentCulture(), Is.False);
    }
  }
}
