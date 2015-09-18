using System.Linq;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.ColorStylers;
using ExcelTableConverter.LatexTableConverter.EmphTextStylers;
using ExcelTableConverter.LatexTableConverter.Justifiers;

namespace ExcelTableConverter.LatexTableConverter.CellFormaters
{
  public class AllStylesCellFormatter : ICellFormatter
  {
    public string Format(Cell cell, ExtendedFeaturesModel featuresModel, Cell firstRowCell)
    {
      var formattedCellValue = cell.Text;

      if (featuresModel.UseColors)
      {
        formattedCellValue = ColorizeTextInCell(cell, formattedCellValue);
        formattedCellValue = ColorizeCellBackground(cell, formattedCellValue);
      }
      formattedCellValue = EmphasiseCellValue(cell, formattedCellValue);
      formattedCellValue = JustifyCellValue(cell, featuresModel.AutoJustify, firstRowCell, formattedCellValue);
      
      // TODO: some more formatting - keep reihenfolge in mind (for LaTeX)

      return formattedCellValue;
    }

    private string ColorizeTextInCell(Cell cell, string value)
    {
      ColorStyler colorStyler = new TextColorStyler();
      return colorStyler.Colorize(cell.TextColor, value);
    }

    private string ColorizeCellBackground(Cell cell, string value)
    {
      ColorStyler colorStyler = new FillColorStyler();
      return colorStyler.Colorize(cell.FillColor, value);
    }

    private string EmphasiseCellValue(Cell cell, string value)
    {
      var emphTextStylers = EmphTextStylerFactory.GetTextStylers(cell);
      return emphTextStylers.Aggregate(value, (current, emphTextStyler) => emphTextStyler.Style(current));
    }

    private string JustifyCellValue(Cell cell, bool autoJustify, Cell firstRowCell, string value)
    {
      if (!HorizontalAlignmentsAreEqual(cell, firstRowCell, autoJustify))
      {
        var justifier = JustifierFactory.GetJustifier(cell, autoJustify);
        return justifier.Justify(value);
      }
      return value;
    }

    private bool HorizontalAlignmentsAreEqual(Cell cell, Cell firstRowCell, bool autoJustify)
    {
      var cellAlignment = GetHorizontalAlignment(cell, autoJustify);
      var firstRowCellAlignment = GetHorizontalAlignment(firstRowCell, autoJustify);
      
      return cellAlignment == firstRowCellAlignment;
    }

    private Cell.HorizontalAlignmentEnum GetHorizontalAlignment(Cell cell, bool autoJustify)
    {
      if (cell.HorizontalAlignment == Cell.HorizontalAlignmentEnum.General && autoJustify)
      {
        return JustifierFactory.DefineHorizontalAlignmentBasedOnDataType(cell).HorizontalAlignment;
      }
      return cell.HorizontalAlignment;
    }
  }
}
