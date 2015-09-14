using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExcelTableConverter.ExcelContent.Model
{
  public class RowCollection : IEnumerable
  {
    public int Count
    {
      get { return _rows.Count(); }
    }

    public int ColumnCount { get; private set; }

    private List<Row> _rows;

    public Row this [int index]
    {
      get { return _rows[index]; }
      set { _rows[index] = value; }
    }
    
    public RowCollection(int columns)
    {
      ColumnCount = columns;
      _rows = new List<Row>();
    }

    public void AddAndInitNewRow()
    {
      _rows.Add(new Row(ColumnCount));
    }

    public Cell GetCellAt(int column, int row)
    {
      CheckBoundsAndThrowException(column, 0, ColumnCount, "invalid column index");
      CheckBoundsAndThrowException(row, 0, Count, "invalid row index");

      return _rows[row].Columns[column];
    }

    private void CheckBoundsAndThrowException(int value, int lowerBound, int upperBound, string message)
    {
      if (value < lowerBound || value >= upperBound)
        throw new ArgumentException(message);
    }

    public IEnumerator GetEnumerator()
    {
      return (_rows as IEnumerable).GetEnumerator();
    }
  }
}
