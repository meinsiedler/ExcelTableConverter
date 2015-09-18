﻿using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class TextExtractor : ExtractorDecorator
  {
    public TextExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);
      cell.Text = excelCell.Text;
      return cell;
    }
  }
}
