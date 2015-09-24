using ExcelTableConverter.TestsCommon;
using NUnit.Framework;

namespace ExcelTableConverter.JiraTableConverter.Tests
{
  [TestFixture]
  public class JiraConverterTests
  {
    private JiraConverter _sut;

    [SetUp]
    public void SetUp()
    {
      _sut = new JiraConverter();
    }

    [Test]
    public void GetFileExtension_ReturnsTxt()
    {
      var result = _sut.GetFileExtension();
      Assert.That(result, Is.EqualTo("txt"));
    }

    [Test]
    public void GetConvertedContent_CompareSimpleTable()
    {
      var expected = "| 1 1 | 1 2 | 1 3 | 1 4 | 1 5 |\r\n| 2 1 | 2 2 | 2 3 | 2 4 | 2 5 |\r\n| 3 1 | 3 2 | 3 3 | 3 4 | 3 5 |\r\n| 4 1 | 4 2 | 4 3 | 4 4 | 4 5 |\r\n";
      var result = _sut.GetConvertedContent(Constants.GetSimpleTable());
      Assert.That(result, Is.EqualTo(expected));
    }
  }
}
