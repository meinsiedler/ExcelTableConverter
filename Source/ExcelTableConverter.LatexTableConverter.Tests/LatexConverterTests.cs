using System.Globalization;
using System.Threading;
using ExcelTableConverter.TestsCommon;
using FakeItEasy;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  public class LatexConverterTests
  {
    [SetUp]
    public void Setup()
    {
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
    }

    [Test]
    public void ConverterName_ReturnsMarkdown()
    {
      Assert.That(new LatexConverter().ConverterName, Is.EqualTo("LaTeX"));
    }

    [Test]
    public void ToString_ReturnsMarkdown()
    {
      Assert.That(new LatexConverter().ToString(), Is.EqualTo("LaTeX"));
    }

    [Test]
    public void GetFileExtension_ReturnsTex()
    {
      var result = new LatexConverter().GetFileExtension();
      Assert.That(result, Is.EqualTo("tex"));
    }

    [Test]
    public void GetConvertedContent_WithNo_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{lllll}\r\n\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithAddTableEnvironment_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.AddTableEnvironment).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{table}\r\n\\centering\r\n\\begin{tabular}{lllll}\r\n\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}\r\n\\caption{SheetName}\r\n\\end{table}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithReplaceConstants_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.ReplaceConstants).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{lllll}\r\n\r\n1 & 20\\% & 1 3 & 1 4 & 1 5 \\\\\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseBorders_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{|l|l|l|l|l|}\r\n\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseBordersAndNoHlines_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);
      A.CallTo(() => extendedFeaturesModel.NoHlines).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{|l|l|l|l|l|}\r\n\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseBordersAndAddHlines_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);
      A.CallTo(() => extendedFeaturesModel.AddHlines).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{|l|l|l|l|l|}\r\n\\hline\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\\hline\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\\hline\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\\hline\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\\hline\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseBordersAndFullBorderConfig_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);
      A.CallTo(() => extendedFeaturesModel.FullBorderConfig).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{|l|l|l|l|l|}\r\n\\cdashline{1-1} \r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\\cdashline{1-1}[1pt/1pt] \r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseBordersAndHighQualityTableAndAddTableEnvironment_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.AddTableEnvironment).Returns(true);
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);
      A.CallTo(() => extendedFeaturesModel.HighQualityTable).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{table}\r\n\\renewcommand{\\arraystretch}{1.2}\r\n\\centering\r\n\\begin{tabular}{@{}lllll@{}}\r\n\\toprule\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\\midrule\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\\bottomrule\r\n\r\n\\end{tabular}\r\n\\caption{SheetName}\r\n\\end{table}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseBordersAndHighQualityTable_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);
      A.CallTo(() => extendedFeaturesModel.HighQualityTable).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{@{}lllll@{}}\r\n\\toprule\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\\midrule\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\\bottomrule\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithUseColors_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.UseColors).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{lllll}\r\n\r\n1 & 20% & \\cellcolor[rgb]{0,1,1}{1 3} & \\textcolor[rgb]{1,0,0}{1 4} & \\cellcolor[rgb]{0,1,1}{\\textcolor[rgb]{1,0,0}{1 5}} \\\\\r\n\\textbf{2 1} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n3 1 & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n4 1 & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WitAutoJustify_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.AutoJustify).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{rllll}\r\n\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\r\n\\multicolumn{1}{l}{\\textbf{2 1}} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n\\multicolumn{1}{l}{3 1} & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n\\multicolumn{1}{l}{4 1} & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WitAutoJustifyAndUseBorders_ExtendedFeature()
    {
      var extendedFeaturesModel = A.Fake<IExtendedLatexFeaturesModel>();
      A.CallTo(() => extendedFeaturesModel.TableName).Returns("SheetName");
      A.CallTo(() => extendedFeaturesModel.AutoJustify).Returns(true);
      A.CallTo(() => extendedFeaturesModel.UseBorders).Returns(true);

      var latexConverter = new LatexConverter(extendedFeaturesModel);

      var expected = "\\begin{tabular}{|r|l|l|l|l|}\r\n\r\n1 & 20% & 1 3 & 1 4 & 1 5 \\\\\r\n\\multicolumn{1}{|l|}{\\textbf{2 1}} & \\textit{2 2} & \\textit{\\textbf{2 3}} & 2 4 & 2 5 \\\\\r\n\\multicolumn{1}{|l|}{3 1} & 3 2 & 3 3 & 3 4 & 3 5 \\\\\r\n\\multicolumn{1}{|l|}{4 1} & 4 2 & 4 3 & 4 4 & 4 5 \\\\\r\n\r\n\\end{tabular}";
      var result = latexConverter.GetConvertedContent(Constants.GetTableWithAllFeatures());
      Assert.That(result, Is.EqualTo(expected));
    }
    
  }
}
