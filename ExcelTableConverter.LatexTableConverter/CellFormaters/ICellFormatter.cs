using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.LatexTableConverter.CellFormaters
{
  interface ICellFormatter
  {
    string Format(Cell cell, ExtendedFeaturesModel extendedFeatures, Cell firstRowCell);
  }
}
