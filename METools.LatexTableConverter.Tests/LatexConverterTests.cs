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
      Assert.AreEqual("tex", result);
    }

    [Test]
    public void GetConvertedContent_CompareSimpleTable()
    {
      var expected =
        "\\begin{table}[!ht]\r\n\\centering\r\n\\begin{tabular}{|l|l|l|l|l|}\r\n\\multicolumn{1}{|r|}{1 1} & \\multicolumn{1}{|r|}{1 2} & \\multicolumn{1}{|r|}{1 3} & \\multicolumn{1}{|r|}{1 4} & \\multicolumn{1}{|r|}{1 5} \\\\\\multicolumn{1}{|r|}{2 1} & \\multicolumn{1}{|r|}{2 2} & \\multicolumn{1}{|r|}{2 3} & \\multicolumn{1}{|r|}{2 4} & \\multicolumn{1}{|r|}{2 5} \\\\\\multicolumn{1}{|r|}{3 1} & \\multicolumn{1}{|r|}{3 2} & \\multicolumn{1}{|r|}{3 3} & \\multicolumn{1}{|r|}{3 4} & \\multicolumn{1}{|r|}{3 5} \\\\\\multicolumn{1}{|r|}{4 1} & \\multicolumn{1}{|r|}{4 2} & \\multicolumn{1}{|r|}{4 3} & \\multicolumn{1}{|r|}{4 4} & \\multicolumn{1}{|r|}{4 5} \\\\\\end{tabular}\r\n\\caption{simple table}\r\n\\end{table}";
      var result = _sut.GetConvertedContent(Constants.GetSimpleTable());
      Assert.AreEqual(expected, result);
    }

  }
}
