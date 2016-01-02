using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExcelTableConverter.ExcelContent.Model
{
  public class RowCollection : IEnumerable<Row>
  {
    public int Count
    {
      get { return _rows.Count(); }
    }

    public int ColumnCount { get; private set; }

    private readonly List<Row> _rows;

    public Row this [int index]
    {
      get { return _rows[index]; }
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


    public IEnumerator<Row> GetEnumerator()
    {
      return _rows.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
