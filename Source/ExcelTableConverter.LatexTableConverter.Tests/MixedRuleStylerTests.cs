﻿using System.Collections.Generic;
using System.Text;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.BorderStylers;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  class MixedRuleStylerTests
  {
    private RuleStylerTestsCommon _ruleStylerTestsCommon;

    [SetUp]
    public void SetUp()
    {
      _ruleStylerTestsCommon = new RuleStylerTestsCommon();
    }

    [Test]
    public void TestClineMixedWithHhLine()
    {
      var row = _ruleStylerTestsCommon.InitRowMixed();
      var fullBorders = new StringBuilder();

      Dictionary<Row, HorizontalRuleStyler> horizontalRuleStylers = HorizontalRuleStylerFactory.GetBottomHorizontalRuleStyler(row);
      foreach (var horizontalRuleStyler in horizontalRuleStylers)
      {
        fullBorders.Append(horizontalRuleStyler.Value.GetBottomHorizontalRule(horizontalRuleStyler.Key));
      }

      var expected = @"\cdashline{1-2}[1pt/1pt] \cdashline{4-5} \hhline{~~-~~=}";

      Assert.That(fullBorders.ToString(), Is.EqualTo(expected));
    }

  }
}
