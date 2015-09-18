using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.Justifiers;
using NUnit.Framework;

namespace ExcelTableConverter.LatexTableConverter.Tests
{
  [TestFixture]
  class JustifiersTests
  {
    [Test]
    public void JustifierFactory_WithNumeric_ReturnsRightHorizontalAlignment()
    {
      var cell = new Cell {Text = "123"};
      Assert.That(JustifierFactory.DefineHorizontalAlignmentBasedOnDataType(cell).HorizontalAlignment, Is.EqualTo(Cell.HorizontalAlignmentEnum.Right));
    }

    [Test]
    public void JustifierFactory_WithNumeric_ReturnsLeftHorizontalAlignment()
    {
      var cell = new Cell { Text = "abc" };
      Assert.That(JustifierFactory.DefineHorizontalAlignmentBasedOnDataType(cell).HorizontalAlignment, Is.EqualTo(Cell.HorizontalAlignmentEnum.Left));
    }

    [Test]
    public void JustifierFactory_WithAutoJustifyAndNumeric_ReturnsRightJustifier()
    {
      var cell = new Cell { Text = "123" };
      Assert.That(JustifierFactory.GetJustifier(cell, autoJustify:true), Is.TypeOf<RightJustifier>());
    }

    [Test]
    public void JustifierFactory_WithoutAutoJustifyAndNumeric_ReturnsLeftJustifier()
    {
      var cell = new Cell { Text = "123" };
      Assert.That(JustifierFactory.GetJustifier(cell, autoJustify: false), Is.TypeOf<LeftJustifier>());
    }

    [Test]
    public void JustifierFactory_WithAutoJustifyAndNotNumeric_ReturnsLeftJustifier()
    {
      var cell = new Cell { Text = "abc" };
      Assert.That(JustifierFactory.GetJustifier(cell, autoJustify: true), Is.TypeOf<LeftJustifier>());
    }

  }
}
