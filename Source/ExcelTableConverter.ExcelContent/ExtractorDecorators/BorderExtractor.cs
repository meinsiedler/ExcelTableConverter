using System.Collections.Generic;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class BorderExtractor : ExtractorDecorator
  {
    public BorderExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);

      cell.Borders = GetBorders(excelCell);
      return cell;
    }

    private Dictionary<Cell.BorderPositionEnum, BorderInformation> GetBorders(IRange excelCell)
    {
      var borders = new Dictionary<Cell.BorderPositionEnum, BorderInformation>();
      borders[Cell.BorderPositionEnum.Left] = GetBorderInformation(excelCell.Borders[Cell.BorderPositionEnum.Left]);
      borders[Cell.BorderPositionEnum.Top] = GetBorderInformation(excelCell.Borders[Cell.BorderPositionEnum.Top]);
      borders[Cell.BorderPositionEnum.Right] = GetBorderInformation(excelCell.Borders[Cell.BorderPositionEnum.Right]);
      borders[Cell.BorderPositionEnum.Bottom] = GetBorderInformation(excelCell.Borders[Cell.BorderPositionEnum.Bottom]);

      return borders;
    }

    private BorderInformation GetBorderInformation(IBorder border)
    {
      return new BorderInformation
      {
        BorderStyle = border.LineStyle,
        Thickness = border.Weight
      };
    }
  }
}
