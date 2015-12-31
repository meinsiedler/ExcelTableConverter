using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExcelTableConverter.TestsCommon;
using NUnit.Framework;

namespace ExcelTableConverter.MarkdownTableConverter.Tests
{
  [TestFixture]
  public class MarkdownConverterTests
  {
    [SetUp]
    public void SetUp()
    {
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
    }

    [Test]
    public void ConverterName_ReturnsMarkdown()
    {
      Assert.That(new MarkdownConverter().ConverterName, Is.EqualTo("Markdown"));
    }

    [Test]
    public void ToString_ReturnsMarkdown()
    {
      Assert.That(new MarkdownConverter().ToString(), Is.EqualTo("Markdown"));
    }

    [Test]
    public void GetFileExtension_ReturnsMd()
    {
      var result = new MarkdownConverter().GetFileExtension();
      Assert.That(result, Is.EqualTo("md"));
    }

    [Test]
    public void GetConvertedContent_WithNo_ExtendedFeature()
    {
      var markdownConverter = new MarkdownConverter();

      var expected = "| 1 1 | 1 2 | 1 3 | 1 4 | 1 5 |\r\n|-----|-----|-----|-----|-----|\r\n| 2 1 | 2 2 | 2 3 | 2 4 | 2 5 |\r\n| 3 1 | 3 2 | 3 3 | 3 4 | 3 5 |\r\n| 4 1 | 4 2 | 4 3 | 4 4 | 4 5 |\r\n";
      var result = markdownConverter.GetConvertedContent(Constants.GetSimpleTable());
      Assert.That(result, Is.EqualTo(expected));
    }
  }
}
