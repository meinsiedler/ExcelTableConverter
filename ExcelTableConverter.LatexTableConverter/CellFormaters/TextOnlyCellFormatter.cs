using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.LatexTableConverter.CellFormaters
{
  class TextOnlyCellFormatter : ICellFormatter
  {
    public string Format(Cell cell, ExtendedFeaturesModel featuresModel, Cell firstRowCell)
    {
      return cell.Text;
    }
  }
}
