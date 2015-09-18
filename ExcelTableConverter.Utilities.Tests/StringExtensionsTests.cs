using System.Globalization;
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
      var result = "1.234,5".IsNumericCurrentCulture();
      Assert.That(result, Is.EqualTo(true));
    }
  }
}
