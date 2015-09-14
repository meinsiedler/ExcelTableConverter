using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter.Tests
{
  class RuleStylerTestsCommon
  {
    public Row InitRowTop34NotDashedBottom158NotDashed()
    {
      Row row = new Row(8);
      int i = 1;
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        if (i != 3 && i != 4)
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
        else
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.None;

        if (i != 1 && i != 5 && i != 8)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
        else
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.None;
        i++;
      }

      return row;
    }

    public Row InitRowTopAndBottom12Double3None456Solid78None()
    {
      Row row = new Row(8);
      int i = 1;
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        if (i ==1 || i == 2)
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.DoubleLineSolid;
        else if(i == 4 || i == 5 || i == 6)
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.Solid;
        else
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.None;

        if (i == 1 || i == 2)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.DoubleLineSolid;
        else if (i == 4 || i == 5 || i == 6)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Solid;
        else
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.None;
        i++;
      }

      return row;
    }

    public Row InitRowTopBottom12Solid3DoubleSolid()
    {
      Row row = new Row(3);
      int i = 1;
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        if (i == 1 || i == 2)
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.Solid;
        else if (i == 3)
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.DoubleLineSolid;
        else
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.None;

        if (i == 1 || i == 2)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Solid;
        else if (i == 3)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.DoubleLineSolid;
        else
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.None;
        i++;
      }

      return row;
    }


    public Row InitRowNoTopAndBottomBorderSet()
    {
      Row row = new Row(8);
      int i = 1;
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.None;
        cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.None;
        i++;
      }

      return row;
    }

    public Row InitRowOnlyFirstCellDashed()
    {
      Row row = new Row(8);
      int i = 1;
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        if (i == 1)
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
        else
          cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.None;

        if (i == 1)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
        else
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.None;
        i++;
      }
      return row;
    }

    public Row InitRowAllCellsDashed()
    {
      Row row = new Row(8);
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        cell.Borders[Cell.BorderPositionEnum.Top].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
        cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
      }
      return row;
    }

    public Row InitRowMixed()
    {
      Row row = new Row(6);
      var i = 1;
      foreach (var cell in row.Columns)
      {
        cell.Borders = InitBorders();
        if(i == 1 || i == 2)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Dotted;
        if(i == 3)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Solid;
        if(i == 4 || i == 5)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.Dashed;
        if(i == 6)
          cell.Borders[Cell.BorderPositionEnum.Bottom].BorderStyle = BorderInformation.BorderStyleEnum.DoubleLineSolid;
        i++;
      }
      return row;
    }

    private Dictionary<Cell.BorderPositionEnum, BorderInformation> InitBorders()
    {
      Dictionary<Cell.BorderPositionEnum, BorderInformation> borders = new Dictionary<Cell.BorderPositionEnum, BorderInformation>();
      borders[Cell.BorderPositionEnum.Left] = new BorderInformation();
      borders[Cell.BorderPositionEnum.Top] = new BorderInformation();
      borders[Cell.BorderPositionEnum.Right] = new BorderInformation();
      borders[Cell.BorderPositionEnum.Bottom] = new BorderInformation();
      return borders;
    }
  }
}
