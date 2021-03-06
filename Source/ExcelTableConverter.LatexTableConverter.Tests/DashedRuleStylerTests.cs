﻿using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.BorderStylers;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  public class DashedRuleStylerTests
  {

    private DashedRuleStyler _sut;
    private RuleStylerTestsCommon _ruleStylerTestsCommon;

    [SetUp]
    public void SetUp()
    {
      _sut = new DashedRuleStyler();
      _ruleStylerTestsCommon = new RuleStylerTestsCommon();
    }

    

    [Test]
    public void GetCDashLineFromTopBorder()
    {
      Row row = _ruleStylerTestsCommon.InitRowTop34NotDashedBottom158NotDashed();
      string actual = _sut.GetTopHorizontalRule(row);
      var expected = @"\cdashline{1-2} \cdashline{5-8} ";
      Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCDashLineFromBottomBorder()
    {
      Row row = _ruleStylerTestsCommon.InitRowTop34NotDashedBottom158NotDashed();
      string actual = _sut.GetBottomHorizontalRule(row);
      var expected = @"\cdashline{2-4} \cdashline{6-7} ";
      Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCLineOnlyFirstCellDashed()
    {
      Row row = _ruleStylerTestsCommon.InitRowOnlyFirstCellDashed();
      string actual = _sut.GetTopHorizontalRule(row);
      var expected = @"\cdashline{1-1} ";
      Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCLineOnlyAllCellsDashed()
    {
      Row row = _ruleStylerTestsCommon.InitRowAllCellsDashed();
      string actual = _sut.GetTopHorizontalRule(row);
      var expected = @"\cdashline{1-8} ";
      Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void NoBorderSet()
    {
      Row row = _ruleStylerTestsCommon.InitRowNoTopAndBottomBorderSet();
      string actual = _sut.GetTopHorizontalRule(row);
      Assert.That(actual, Is.EqualTo(string.Empty));
    }
  }
}
