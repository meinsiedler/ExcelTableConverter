using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using METools.TestsCommon;
using NUnit.Framework;

namespace METools.WikiTableConverter.Tests
{
  [TestFixture]
  public class JiraWikiConverterTests
  {
    private JiraWikiConverter _sut;

    [SetUp]
    public void SetUp()
    {
      _sut = new JiraWikiConverter();
    }

    [Test]
    public void GetFileExtension_ReturnsTxt()
    {
      var result = _sut.GetFileExtension();
      Assert.AreEqual("txt", result);
    }

    [Test]
    public void GetConvertedContent_CompareSimpleTable()
    {
      var expected = "| 1 1 | 1 2 | 1 3 | 1 4 | 1 5 |\r\n| 2 1 | 2 2 | 2 3 | 2 4 | 2 5 |\r\n| 3 1 | 3 2 | 3 3 | 3 4 | 3 5 |\r\n| 4 1 | 4 2 | 4 3 | 4 4 | 4 5 |\r\n";
      var result = _sut.GetConvertedContent(Constants.GetSimpleTable());
      Assert.AreEqual(expected, result);
    }
  }
}
