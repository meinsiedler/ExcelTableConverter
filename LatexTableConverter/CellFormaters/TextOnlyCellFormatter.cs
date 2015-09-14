using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter.CellFormaters
{
  class TextOnlyCellFormatter : ICellFormatter
  {
    public string Format(Cell cell, ExtendedFeaturesModel featuresModel, Cell firstRowCell)
    {
      return cell.Text;
    }
  }
}
