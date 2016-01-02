using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent
{
  public abstract class ExcelReader
  {
    public Table GetExcelTable(IWorksheet worksheet, Selection selection)
    {
      Table table = new Table(worksheet.Name, selection.ColumnCount, selection.RowCount);
      int rowOffset = selection.StartRow;
      int columnOffset = selection.StartColumn;
      for (int i = 0; i < selection.RowCount; i++)
      {
        for (int j = 0; j < selection.ColumnCount; j++)
        {
          var excelCell = worksheet.Cells[i + rowOffset, j + columnOffset];
          table.Rows[i].Columns[j] = ExtractExcelCellProperty(excelCell);
        }
      }
      return table;
    }

    public abstract Cell ExtractExcelCellProperty(IRange excelCell);
  }
}
