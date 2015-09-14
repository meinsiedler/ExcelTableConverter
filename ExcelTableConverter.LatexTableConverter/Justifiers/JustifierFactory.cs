using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.Utilities;

namespace ExcelTableConverter.LatexTableConverter.Justifiers
{
  public static class JustifierFactory
  {
    public static Justifier GetJustifier(Cell cell, bool autoJustify)
    {
      if(cell.HorizontalAlignment == Cell.HorizontalAlignmentEnum.General && autoJustify)
        cell = DefineHorizontalAlignmentBasedOnDataType(cell);

      if(cell.HorizontalAlignment == Cell.HorizontalAlignmentEnum.Right)
      {
        return new RightJustifier();
      }
      if (cell.HorizontalAlignment == Cell.HorizontalAlignmentEnum.Center)
      {
        return new CenterJustifier();
      }
      return new LeftJustifier();
    }

    public static Cell DefineHorizontalAlignmentBasedOnDataType(Cell cell)
    {
      if (cell.Text.IsNumericCurrentCulture())
        cell.HorizontalAlignment = Cell.HorizontalAlignmentEnum.Right;
      else
        cell.HorizontalAlignment = Cell.HorizontalAlignmentEnum.Left;
      return cell;
    }
  }
}
