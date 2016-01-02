using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.MarkdownTableConverter.CellFormatters
{
  public interface ICellFormatter
  {
    string Format(Cell cell);
  }
}
