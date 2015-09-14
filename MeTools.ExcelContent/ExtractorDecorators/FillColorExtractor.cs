using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace MeTools.ExcelContent.ExtractorDecorators
{
  public class FillColorExtractor : ExtractorDecorator
  {
    private ExcelReader _excelReader;

    public FillColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
      _excelReader = excelReader;
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = _excelReader.ExtractExcelCellProperty(excelCell);

      cell.FillColor = System.Drawing.ColorTranslator.FromOle((int)excelCell.Interior.Color);
      return cell;
    }
  }
}
