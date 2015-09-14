using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.BorderStylers;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  class SolidRuleStylerTests
  {
    private SolidRuleStyler _sut;
    private RuleStylerTestsCommon _ruleStylerTestsCommon;

    [SetUp]
    public void SetUp()
    {
      _sut = new SolidRuleStyler();
      _ruleStylerTestsCommon = new RuleStylerTestsCommon();
    }

    [Test]
    public void GetCDashLineFromTopBorder()
    {
      Row row = _ruleStylerTestsCommon.InitRowTop34NotDashedBottom158NotDashed();
      string actual = _sut.GetTopHorizontalRule(row);
      var expected = @"\hhline{--~~----}";
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetCDashLineFromBottomBorder()
    {
      Row row = _ruleStylerTestsCommon.InitRowTopAndBottom12Double3None456Solid78None();
      string actual = _sut.GetBottomHorizontalRule(row);
      var expected = @"\hhline{==~---~~}";
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetSolidAndDoubleLineFromBorder()
    {
      Row row = _ruleStylerTestsCommon.InitRowTopBottom12Solid3DoubleSolid();
      var actual = _sut.GetBottomHorizontalRule(row);
      var expected = @"\hhline{--=}";
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void NoBorderSet()
    {
      Row row = _ruleStylerTestsCommon.InitRowNoTopAndBottomBorderSet();
      string actual = _sut.GetTopHorizontalRule(row);
      Assert.AreEqual(string.Empty, actual);
    }

    //[Test]
    //public void GetCLineOnlyFirstCellDashed()
    //{
    //  Row row = _ruleStylerTestsCommon.InitRowOnlyFirstCellDashed();
    //  string actual = _sut.GetTopHorizontalRule(row);
    //  var expected = @"\cdashline{1-1} ";
    //  Assert.AreEqual(expected, actual);
    //}

    //[Test]
    //public void GetCLineOnlyAllCellsDashed()
    //{
    //  Row row = _ruleStylerTestsCommon.InitRowAllCellsDashed();
    //  string actual = _sut.GetTopHorizontalRule(row);
    //  var expected = @"\cdashline{1-8} ";
    //  Assert.AreEqual(expected, actual);
    //}
  }
}
