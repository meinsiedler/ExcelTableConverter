using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.LatexTableConverter.CellFormaters
{
  interface ICellFormatter
  {
    string Format(Cell cell, IExtendedLatexFeaturesModel extendedFeatures, Cell firstRowCell);
  }
}
