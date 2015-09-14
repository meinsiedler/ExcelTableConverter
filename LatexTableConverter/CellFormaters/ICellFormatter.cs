using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter.CellFormaters
{
  interface ICellFormatter
  {
    string Format(Cell cell, ExtendedFeaturesModel extendedFeatures, Cell firstRowCell);
  }
}
