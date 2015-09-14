using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace MeTools.ExcelContent
{
  public class ExcelExtractor : ExcelReader
  {
    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      return new Cell();
    }
  }
}
