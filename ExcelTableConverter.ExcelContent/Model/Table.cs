using ExcelTableConverter.Utilities;

namespace ExcelTableConverter.ExcelContent.Model
{
  public class Table
  {
    public RowCollection Rows { get; set; }

    public string SheetName { get; set; }

    public Table(string sheetName, int columns, int rows)
    {
      ArgumentUtility.EnsureNotNull(sheetName, "sheetName");
      ArgumentUtility.EnsureCondition(columns, c => c > 0, "columns");
      ArgumentUtility.EnsureCondition(rows, r => r > 0, "rows");

      Rows = new RowCollection(columns);
      for (int i = 0; i < rows; i++)
      {
        Rows.AddAndInitNewRow();
      }
      SheetName = sheetName;
    }

    
  }
}
