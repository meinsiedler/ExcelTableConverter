using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.MarkdownTableConverter.EmphTextStylers
{
  public class EmphTextStylerFactory : TableConverter.EmphTextStylers.EmphTextStylerFactory
  {
    protected override EmphTextStyler GetBoldTextStyler()
    {
      return new BoldTextStyler();
    }

    protected override EmphTextStyler GetItalicTextStyler()
    {
      return new ItalicTextStyler();
    }
  }
}
