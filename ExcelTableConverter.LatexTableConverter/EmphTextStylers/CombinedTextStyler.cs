using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTableConverter.LatexTableConverter.EmphTextStylers
{
  public class CombinedTextStyler : EmphTextStyler
  {
    private readonly IEnumerable<EmphTextStyler> _emphTextStylers;

    public CombinedTextStyler(IEnumerable<EmphTextStyler> emphTextStylers)
    {
      _emphTextStylers = emphTextStylers;
    }

    public override string Style(string text)
    {
      return _emphTextStylers.Aggregate(text, (current, emphTextStyler) => emphTextStyler.Style(current));
    }
  }
}
