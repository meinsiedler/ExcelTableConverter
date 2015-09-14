using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace METools.LatexTableConverter
{
  public static class LatexConstants
  {
    public static Dictionary<string, string> Constants = new Dictionary<string, string>
      {
        {"%", @"\%"},
        {"&", @"\&"},
        //{@"\", @"\textbackslash"}, // TODO: replaces % -> \% -> \textbackslash%; do not touch already replaces strings
        {"€", @"\geneuro"},
        {@"{", @"\{"},
        {@"}", @"\}"},
        {"_", @"\textunderscore"},
      };
  }
}
