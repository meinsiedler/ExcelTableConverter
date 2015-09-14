using System.Collections.Generic;
using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class BorderExtractor : ExtractorDecorator
  {
    private readonly ExcelReader _excelReader;

    public BorderExtractor(ExcelReader excelReader) : base(excelReader)
    {
      _excelReader = excelReader;
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = _excelReader.ExtractExcelCellProperty(excelCell);

      cell.Borders = GetBorders(excelCell);
      return cell;
    }

    private Dictionary<Cell.BorderPositionEnum, BorderInformation> GetBorders(Range excelCell)
    {
      var borders = new Dictionary<Cell.BorderPositionEnum, BorderInformation>();
      borders[Cell.BorderPositionEnum.Left] = GetBorderInformation(excelCell.Borders[XlBordersIndex.xlEdgeLeft]);
      borders[Cell.BorderPositionEnum.Top] = GetBorderInformation(excelCell.Borders[XlBordersIndex.xlEdgeTop]);
      borders[Cell.BorderPositionEnum.Right] = GetBorderInformation(excelCell.Borders[XlBordersIndex.xlEdgeRight]);
      borders[Cell.BorderPositionEnum.Bottom] = GetBorderInformation(excelCell.Borders[XlBordersIndex.xlEdgeBottom]);

      return borders;
    }

    private BorderInformation GetBorderInformation(Border border)
    {
      BorderInformation borderInformation = new BorderInformation();
      borderInformation.BorderStyle = GetBorderStyleFromLineStyle(border);
      borderInformation.Thickness = GetThicknessFromWeight(border);
      return borderInformation;
    }

    private BorderInformation.BorderStyleEnum GetBorderStyleFromLineStyle(Border border)
    {
      if(border.LineStyle == (int)XlLineStyle.xlContinuous)
        return BorderInformation.BorderStyleEnum.Solid;
      if (border.LineStyle == (int)XlLineStyle.xlDash)
        return BorderInformation.BorderStyleEnum.Dashed;
      if (border.LineStyle == (int)XlLineStyle.xlDot)
        return BorderInformation.BorderStyleEnum.Dotted;
      if (border.LineStyle == (int)XlLineStyle.xlDouble)
        return BorderInformation.BorderStyleEnum.DoubleLineSolid;

      return BorderInformation.BorderStyleEnum.None;
    }

    private BorderInformation.ThicknessEnum GetThicknessFromWeight(Border border)
    {
      if (border.Weight == (int)XlBorderWeight.xlHairline)
        return BorderInformation.ThicknessEnum.Hairline;
      if (border.Weight == (int)XlBorderWeight.xlThin)
        return BorderInformation.ThicknessEnum.Thin;
      if (border.Weight == (int)XlBorderWeight.xlMedium)
        return BorderInformation.ThicknessEnum.Medium;
      if (border.Weight == (int)XlBorderWeight.xlThick)
        return BorderInformation.ThicknessEnum.Thick;

      return BorderInformation.ThicknessEnum.Hairline;
    }
  }
}
