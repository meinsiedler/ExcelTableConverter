using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
  }
}
