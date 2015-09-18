using System;
using System.Collections.Generic;

namespace ExcelTableConverter.ExcelContent.Model
{
  [Serializable]
  public class Row
  {
    private int _columnsCount;
    public List<Cell> Columns { get; set; }

    public Row(int columns)
    {
      _columnsCount = columns;
      Columns = new List<Cell>(_columnsCount);
      InitCells();
    }

    private void InitCells()
    {
      for (int i = 0; i < _columnsCount; i++)
      {
        Columns.Add(new Cell());
      }
    }
  }
}
