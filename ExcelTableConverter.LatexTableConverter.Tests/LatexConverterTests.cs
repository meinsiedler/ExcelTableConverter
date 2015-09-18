using ExcelTableConverter.TestsCommon;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  public class LatexConverterTests
  {
    private LatexConverter _sut;

    [SetUp]
    public void SetUp()
    {
      _sut = new LatexConverter();
    }

    [Test]
    public void GetFileExtension_ReturnsTex()
    {
      var result = _sut.GetFileExtension();
      Assert.That(result, Is.EqualTo("tex"));
    }

    [Test]
    public void GetConvertedContent_CompareSimpleTable()
    {
      var expected = "\\begin{table}[!ht]\r\n\\centering\r\n\\begin{tabular}{|l|l|l|l|l|}\r\n\r\n1 1 & 1 2 & 1 3 & 1 4 & 1 5 \\\\\r\n2 1 & 2 2 & 2 3 & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}\r\n\\caption{simple table}\r\n\\end{table}";
      var result = _sut.GetConvertedContent(Constants.GetSimpleTable());
      Assert.That(result, Is.EqualTo(expected));
    }

  }
}
