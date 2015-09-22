using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using FakeItEasy;
using NUnit.Framework;

namespace ExcelTableConverter.ExcelContent.Tests
{
  [TestFixture]
  class ExcelReaderTests
  {
    private IWorksheet _worksheet;
    private ExcelReader _sut;

    [SetUp]
    public void SetUp()
    {
      var rangesInWorksheet = new IRange[3][];
      for (int i = 0; i < rangesInWorksheet.Length; i++)
      {
        rangesInWorksheet[i] = A.CollectionOfFake<IRange>(4).ToArray();
        for (int j = 0; j < rangesInWorksheet[i].Length; j++)
        {
          A.CallTo(() => rangesInWorksheet[i][j].Text).Returns(string.Format("{0} {1}", i+1, j+1));
        }
      }

      var range = A.Fake<IRange>();
      for (int i = 0; i < rangesInWorksheet.Length; i++)
      {
        for (int j = 0; j < rangesInWorksheet[i].Length; j++)
        {
          A.CallTo(() => range[i+1, j+1]).Returns(rangesInWorksheet[i][j]);
        }
      }

      _worksheet = A.Fake<IWorksheet>();
      A.CallTo(() => _worksheet.Name).Returns("WorksheetName");
      A.CallTo(() => _worksheet.Cells).Returns(range);

      _sut = ExcelReaderFactory.CreateExcelReader();
    }

    [Test]
    public void ExcelReader_WithFullWorksheetRangeSelection_GetsTable()
    {
      var selection = new Selection {StartColumn = 1, StartRow = 1, ColumnCount = 4, RowCount = 3};

      var table = _sut.GetExcelTable(_worksheet, selection);

      Assert.That(table.SheetName, Is.EqualTo("WorksheetName"));
      Assert.That(table.Rows.Count, Is.EqualTo(3));

      for (int i = 0; i < selection.RowCount; i++)
      {
        Assert.That(table.Rows[i].Columns.Count, Is.EqualTo(4));
        for (int j = 0; j < selection.ColumnCount; j++)
        {
          Assert.That(table.Rows[i].Columns[j].Text, Is.EqualTo(string.Format("{0} {1}", i + 1, j + 1)));
        }
      }
    }

    [Test]
    public void ExcelReader_WithSingleCellSelection_GetsTable()
    {
      var selection = new Selection { StartColumn = 1, StartRow = 1, ColumnCount = 1, RowCount = 1 };

      var table = _sut.GetExcelTable(_worksheet, selection);

      Assert.That(table.SheetName, Is.EqualTo("WorksheetName"));
      Assert.That(table.Rows.Count, Is.EqualTo(1));
      Assert.That(table.Rows[0].Columns.Count, Is.EqualTo(1));
      Assert.That(table.Rows[0].Columns[0].Text, Is.EqualTo("1 1"));
    }
  }
}
