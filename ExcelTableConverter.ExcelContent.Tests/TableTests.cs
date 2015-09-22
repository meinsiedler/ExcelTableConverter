using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using NUnit.Framework;

namespace ExcelTableConverter.ExcelContent.Tests
{
  [TestFixture]
  class TableTests
  {
    [Test]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public void Constructor_WithInvalidParameter_ThrowsException()
    {
      Assert.Throws<ArgumentException>(() => new Table("SheetName", -1, 1));
      Assert.Throws<ArgumentException>(() => new Table("SheetName", 1, -1));
      Assert.Throws<ArgumentException>(() => new Table("SheetName", 0, 1));
      Assert.Throws<ArgumentException>(() => new Table("SheetName", 1, 0));
      Assert.Throws<ArgumentException>(() => new Table("SheetName", -1, -1));
      Assert.Throws<ArgumentException>(() => new Table("SheetName", 0, 0));
      Assert.Throws<ArgumentNullException>(() => new Table(null, 1, 1));
    }
  }
}
