using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.LatexTableConverter.ColorStylers;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  class ColorStylersTests
  {
    [Test]
    public void TextColorStyler_WithRgbValues_ReturnsTextColorCommand()
    {
      var colorStyler = new TextColorStyler();
      Assert.That(colorStyler.Colorize(Color.Red, "text"), Is.EqualTo(@"\textcolor[rgb]{1,0,0}{text}"));
    }

    [Test]
    public void TextColorStyler_WithExcludeColor_ReturnsInputText()
    {
      var colorStyler = new TextColorStyler();
      Assert.That(colorStyler.Colorize(Color.Black, "text"), Is.EqualTo("text"));
    }

    [Test]
    public void FillColorStyler_WithRgbValues_ReturnsCellColorCommand()
    {
      var colorStyler = new FillColorStyler();
      Assert.That(colorStyler.Colorize(Color.Red, "text"), Is.EqualTo(@"\cellcolor[rgb]{1,0,0}{text}"));
    }

    [Test]
    public void FillColorStyler_WithExcludeColor_ReturnsInputText()
    {
      var colorStyler = new FillColorStyler();
      Assert.That(colorStyler.Colorize(Color.White, "text"), Is.EqualTo("text"));
    }
  }
}
