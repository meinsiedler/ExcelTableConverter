using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTableConverter.ExcelContent.Model
{
  public interface IRange
  {
    IRange this[int rowIndex, int columnIndex] { get; }
    string Text { get; }

    IDictionary<Cell.BorderPositionEnum, IBorder> Borders { get; } 

    Cell.HorizontalAlignmentEnum HorizontalAlignment { get; }

    IFont Font { get; }

    int OleFillColor { get; }
  }
}
