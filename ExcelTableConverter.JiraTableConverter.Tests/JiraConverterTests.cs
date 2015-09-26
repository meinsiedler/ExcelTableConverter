using System.Globalization;
using System.Threading;
using ExcelTableConverter.TestsCommon;
using FakeItEasy;
using NUnit.Framework;

namespace ExcelTableConverter.JiraTableConverter.Tests
{
  [TestFixture]
  public class JiraConverterTests
  {
    [SetUp]
    public void SetUp()
    {
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
    }

    [Test]
    public void GetFileExtension_ReturnsTxt()
    {
      var result = new JiraConverter().GetFileExtension();
      Assert.That(result, Is.EqualTo("txt"));
    }

    [Test]
    public void GetConvertedContent_WithNo_ExtendedFeature()
    {
      var extendedFeatureModel = A.Fake<IExtendedJiraFeatureModel>();

      var jiraConverter = new JiraConverter(extendedFeatureModel);

      var expected = "| 1 1 | 1 2 | 1 3 | 1 4 | 1 5 |\r\n| 2 1 | 2 2 | 2 3 | 2 4 | 2 5 |\r\n| 3 1 | 3 2 | 3 3 | 3 4 | 3 5 |\r\n| 4 1 | 4 2 | 4 3 | 4 4 | 4 5 |\r\n";
      var result = jiraConverter.GetConvertedContent(Constants.GetSimpleTable());
      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetConvertedContent_WithFirstRowIsHeader_ExtendedFeature()
    {
      var extendedFeatureModel = A.Fake<IExtendedJiraFeatureModel>();
      A.CallTo(() => extendedFeatureModel.FirstRowIsHeader).Returns(true);

      var jiraConverter = new JiraConverter(extendedFeatureModel);

      var expected = "|| 1 1 || 1 2 || 1 3 || 1 4 || 1 5 ||\r\n| 2 1 | 2 2 | 2 3 | 2 4 | 2 5 |\r\n| 3 1 | 3 2 | 3 3 | 3 4 | 3 5 |\r\n| 4 1 | 4 2 | 4 3 | 4 4 | 4 5 |\r\n";
      var result = jiraConverter.GetConvertedContent(Constants.GetSimpleTable());
      Assert.That(result, Is.EqualTo(expected));
    }
  }
}
