using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.MarkdownTableConverter.EmphTextStylers
{
  public class BoldTextStyler : EmphTextStyler
  {
    public override string Style(string text)
    {
      return string.Format("**{0}**", text);
    }
  }
}
