namespace MeTools.ExcelContent.Model
{
  public class Table
  {
    public RowCollection Rows { get; set; }

    public string SheetName { get; set; }

    public Table(string sheetName, int columns, int rows)
    {
      Rows = new RowCollection(columns);
      for (int i = 0; i < rows; i++)
      {
        Rows.AddAndInitNewRow();
      }
      SheetName = sheetName;
    }

    
  }
}
