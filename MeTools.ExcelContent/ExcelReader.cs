using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace MeTools.ExcelContent
{
  public abstract class ExcelReader
  {
    public Table GetExcelTable(Worksheet worksheet, Selection selection)
    {
      Table table = new Table(worksheet.Name, selection.ColumnCount, selection.RowCount);
      int rowOffset = selection.StartRow;
      int columnOffset = selection.StartColumn;
      for (int i = 0; i < selection.RowCount; i++)
      {
        for (int j = 0; j < selection.ColumnCount; j++)
        {
          Range excelCell = (Range)worksheet.Cells[i + rowOffset, j + columnOffset];
          table.Rows[i].Columns[j] = ExtractExcelCellProperty(excelCell);
        }
      }
      return table;
    }

    public abstract Cell ExtractExcelCellProperty(Range excelCell);
  }
}
