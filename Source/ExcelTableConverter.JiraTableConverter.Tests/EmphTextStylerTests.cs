using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.JiraTableConverter.EmphTextStylers;
using NUnit.Framework;

namespace ExcelTableConverter.JiraTableConverter.Tests
{
  [TestFixture]
  class EmphTextStylerTests
  {
    private TableConverter.EmphTextStylers.EmphTextStylerFactory _emphTextStylerFactory;

    [SetUp]
    public void SetUp()
    {
      _emphTextStylerFactory = new EmphTextStylerFactory();
    }

    [Test]
    public void EmphTextStylerFactory_WithBold_GetsBoldTextStyler()
    {
      var cell = new Cell {Text = "test", TextEmphasis = new List<Cell.EmphasisEnum> {Cell.EmphasisEnum.Bold}};
      var emphTextStylers = _emphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Count, Is.EqualTo(1));
      Assert.That(emphTextStylers.First(), Is.TypeOf<BoldTextStyler>());
    }

    [Test]
    public void EmphTextStylerFactory_WithItalic_GetsItalicTextStyler()
    {
      var cell = new Cell { Text = "test", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Italic } };
      var emphTextStylers = _emphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Count, Is.EqualTo(1));
      Assert.That(emphTextStylers.First(), Is.TypeOf<ItalicTextStyler>());
    }

    [Test]
    public void EmphTextStylerFactory_WithBoldAndItalic_GetsBoldAndItalicTextStyler()
    {
      var cell = new Cell { Text = "test", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Bold, Cell.EmphasisEnum.Italic } };
      var emphTextStylers = _emphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Count, Is.EqualTo(2));
      Assert.That(emphTextStylers.First(), Is.TypeOf<BoldTextStyler>());
      Assert.That(emphTextStylers.Last(), Is.TypeOf<ItalicTextStyler>());
    }

    [Test]
    public void EmphTextStylerFactory_WithNoEmph_GetsEmptyList()
    {
      var cell = new Cell { Text = "test" };
      var emphTextStylers = _emphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Any(), Is.False);
    }

    [Test]
    public void EmphTextStylerFactory_WithNoneEmphasisEnum_GetsEmptyList()
    {
      var cell = new Cell { Text = "test", TextEmphasis = new List<Cell.EmphasisEnum>{ Cell.EmphasisEnum.None }};
      var emphTextStylers = _emphTextStylerFactory.GetTextStylers(cell);
      Assert.That(emphTextStylers.Any(), Is.False);
    }

    [Test]
    public void BoldTextStyler_ReturnsFormattedValue()
    {
      Assert.That(new BoldTextStyler().Style("text"), Is.EqualTo(@"*text*"));
    }

    [Test]
    public void ItalicTextStyler_ReturnsFormattedValue()
    {
      Assert.That(new ItalicTextStyler().Style("text"), Is.EqualTo(@"_text_"));
    }

    [Test]
    public void BoldAndItalicCombinedTextStyler_ReturnsFormattedValue()
    {
      var cell = new Cell { Text = "text", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Bold, Cell.EmphasisEnum.Italic } };
      Assert.That(_emphTextStylerFactory.GetCombinedTextStyle(cell), Is.EqualTo(@"_*text*_"));
    }

    [Test]
    public void BoldAndItalicCombinedTextStyler_WithExtraSpecified_ReturnsFormattedValue()
    {
      var cell = new Cell { Text = "text", TextEmphasis = new List<Cell.EmphasisEnum> { Cell.EmphasisEnum.Bold, Cell.EmphasisEnum.Italic } };
      Assert.That(_emphTextStylerFactory.GetCombinedTextStyle(cell, "value"), Is.EqualTo(@"_*value*_"));
    }
  }
}
