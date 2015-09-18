using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.EmphTextStylers;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  class EmphTextStylerTests
  {
    [Test]
    public void EmphTextStylerFactory_WithBold_GetsBoldTextStyler()
    {
      var cell = new Cell {Text = "test", TextEmphasis = new List<Cell.EmphasisEnum> {Cell.EmphasisEnum.Bold}};
      var emphTextStylers = EmphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Count, Is.EqualTo(1));
      Assert.That(emphTextStylers.First(), Is.TypeOf<BoldTextStyler>());
    }

    [Test]
    public void EmphTextStylerFactory_WithItalic_GetsItalicTextStyler()
    {
      var cell = new Cell { Text = "test", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Italic } };
      var emphTextStylers = EmphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Count, Is.EqualTo(1));
      Assert.That(emphTextStylers.First(), Is.TypeOf<ItalicTextStyler>());
    }

    [Test]
    public void EmphTextStylerFactory_WithBoldAndItalic_GetsBoldAndItalicTextStyler()
    {
      var cell = new Cell { Text = "test", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Bold, Cell.EmphasisEnum.Italic } };
      var emphTextStylers = EmphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Count, Is.EqualTo(2));
      Assert.That(emphTextStylers.First(), Is.TypeOf<BoldTextStyler>());
      Assert.That(emphTextStylers.Last(), Is.TypeOf<ItalicTextStyler>());
    }

    [Test]
    public void EmphTextStylerFactory_WithNoEmph_GetsEmptyList()
    {
      var cell = new Cell { Text = "test" };
      var emphTextStylers = EmphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Any(), Is.False);
    }

    [Test]
    public void EmphTextStylerFactory_WithNoneEmphasisEnum_GetsEmptyList()
    {
      var cell = new Cell { Text = "test", TextEmphasis = new List<Cell.EmphasisEnum>{ Cell.EmphasisEnum.None }};
      var emphTextStylers = EmphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Any(), Is.False);
    }

    [Test]
    public void BoldTextStyler_ReturnsFormattedValue()
    {
      Assert.That(new BoldTextStyler().Style("text"), Is.EqualTo(@"\textbf{text}"));
    }

    [Test]
    public void ItalicTextStyler_ReturnsFormattedValue()
    {
      Assert.That(new ItalicTextStyler().Style("text"), Is.EqualTo(@"\textit{text}"));
    }

    [Test]
    public void BoldAndItalicCombinedTextStyler_ReturnsFormattedValue()
    {
      var cell = new Cell { Text = "text", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Bold, Cell.EmphasisEnum.Italic } };
      Assert.That(EmphTextStylerFactory.GetCombinedTextStyle(cell), Is.EqualTo(@"\textit{\textbf{text}}"));
    }

    [Test]
    public void BoldAndItalicCombinedTextStyler_WithExtraSpecified_ReturnsFormattedValue()
    {
      var cell = new Cell { Text = "text", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Bold, Cell.EmphasisEnum.Italic } };
      Assert.That(EmphTextStylerFactory.GetCombinedTextStyle(cell, "value"), Is.EqualTo(@"\textit{\textbf{value}}"));
    }
  }
}
