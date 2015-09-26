using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ExcelTableConverter.ExcelContent.ExtractorDecorators;
using ExcelTableConverter.ExcelContent.Model;
using FakeItEasy;
using NUnit.Framework;

namespace ExcelTableConverter.ExcelContent.Tests
{
  [TestFixture]
  public class ExtractorDecoratorTests
  {
    [Test]
    public void TextExtractor_WithText_ReturnsCellWithText()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.Text).Returns("Some text");

      var cell = new TextExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.Text, Is.EqualTo("Some text"));
    }

    [Test]
    public void EmphasisExtractor_WithNoFormat_ReturnsEmptyList()
    {
      var excelCell = A.Fake<IRange>();
      
      var cell = new EmphasisExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.TextEmphasis, Is.Empty);
    }

    [Test]
    public void EmphasisExtractor_WithBold_ReturnsCellWithBoldEmph()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.Font.Bold).Returns(true);

      var cell = new EmphasisExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.TextEmphasis.Single(), Is.EqualTo(Cell.EmphasisEnum.Bold));
    }

    [Test]
    public void EmphasisExtractor_WithItalic_ReturnsCellWithItalicEmph()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.Font.Italic).Returns(true);

      var cell = new EmphasisExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.TextEmphasis.Single(), Is.EqualTo(Cell.EmphasisEnum.Italic));
    }

    [Test]
    public void EmphasisExtractor_WithBoldAndItalic_ReturnsCellWithBoldAndItalicEmph()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.Font.Bold).Returns(true);
      A.CallTo(() => excelCell.Font.Italic).Returns(true);

      var cell = new EmphasisExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.TextEmphasis.Count(), Is.EqualTo(2));
      Assert.That(cell.TextEmphasis.First(), Is.EqualTo(Cell.EmphasisEnum.Italic));
      Assert.That(cell.TextEmphasis.Last(), Is.EqualTo(Cell.EmphasisEnum.Bold));
    }

    [Test]
    public void HorizontalAlignmentExtractor_WithHorizontalAlignmentRight_ReturnsCellWithHorizontalAlignment()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.HorizontalAlignment).Returns(Cell.HorizontalAlignmentEnum.Right);

      var cell = new HorizontalAlignmentExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.HorizontalAlignment, Is.EqualTo(Cell.HorizontalAlignmentEnum.Right));
    }

    [Test]
    public void TextColorExtractor_WithRedOleColor_ReturnsCellWithRedColor()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.Font.OleColor).Returns(255);

      var cell = new TextColorExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.TextColor, Is.EqualTo(Color.Red));
    }

    [Test]
    public void FillColorExtractor_WithRedOleColor_ReturnsCellWithRedColor()
    {
      var excelCell = A.Fake<IRange>();
      A.CallTo(() => excelCell.OleFillColor).Returns(255);

      var cell = new FillColorExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.FillColor, Is.EqualTo(Color.Red));
    }

    [Test]
    public void BorderExtractor_WithAllBorders_ReturnsCellWithAllBorders()
    {
      var excelCell = A.Fake<IRange>();

      var borderDict = new Dictionary<Cell.BorderPositionEnum, IBorder>()
      {
        { Cell.BorderPositionEnum.Left, A.Fake<IBorder>() },
        { Cell.BorderPositionEnum.Top, A.Fake<IBorder>() },
        { Cell.BorderPositionEnum.Right, A.Fake<IBorder>() },
        { Cell.BorderPositionEnum.Bottom, A.Fake<IBorder>() }
      };

      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Left].LineStyle).Returns(BorderInformation.BorderStyleEnum.Dashed);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Left].Weight).Returns(BorderInformation.ThicknessEnum.Hairline);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Top].LineStyle).Returns(BorderInformation.BorderStyleEnum.Dotted);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Top].Weight).Returns(BorderInformation.ThicknessEnum.Medium);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Right].LineStyle).Returns(BorderInformation.BorderStyleEnum.DoubleLineSolid);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Right].Weight).Returns(BorderInformation.ThicknessEnum.Thick);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Bottom].LineStyle).Returns(BorderInformation.BorderStyleEnum.Solid);
      A.CallTo(() => borderDict[Cell.BorderPositionEnum.Bottom].Weight).Returns(BorderInformation.ThicknessEnum.Thin);

      A.CallTo(() => excelCell.Borders).Returns(borderDict);

      var cell = new BorderExtractor(new ExcelExtractor()).ExtractExcelCellProperty(excelCell);
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Left].BorderStyle, Is.EqualTo(BorderInformation.BorderStyleEnum.Dashed));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Left].Thickness, Is.EqualTo(BorderInformation.ThicknessEnum.Hairline));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle, Is.EqualTo(BorderInformation.BorderStyleEnum.Dotted));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Top].Thickness, Is.EqualTo(BorderInformation.ThicknessEnum.Medium));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Right].BorderStyle, Is.EqualTo(BorderInformation.BorderStyleEnum.DoubleLineSolid));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Right].Thickness, Is.EqualTo(BorderInformation.ThicknessEnum.Thick));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle, Is.EqualTo(BorderInformation.BorderStyleEnum.Solid));
      Assert.That(cell.Borders[Cell.BorderPositionEnum.Bottom].Thickness, Is.EqualTo(BorderInformation.ThicknessEnum.Thin));
    }
  }
}
