using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.LatexTableConverter
{
  public interface IExtendedLatexFeaturesModel : IExtendedFeaturesModel
  {
    string TableName { get; }
    bool AddTableEnvironment { get; }
    bool ReplaceConstants { get; }
    bool UseBorders { get; }
    bool NoHlines { get; }
    bool AddHlines { get; }
    bool FullBorderConfig { get; }
    bool HighQualityTable { get; }
    bool UseColors { get; }
    bool AutoJustify { get; }
  }
}
