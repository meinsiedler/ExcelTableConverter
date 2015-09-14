using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace MeTools.ExcelContent.ExtractorDecorators
{
  class TextColorExtractor : ExtractorDecorator
  {
    private ExcelReader _excelReader;

    public TextColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
      _excelReader = excelReader;
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = _excelReader.ExtractExcelCellProperty(excelCell);

      cell.TextColor = System.Drawing.ColorTranslator.FromOle((int) excelCell.Font.Color);
      return cell;
    }
  }
}
