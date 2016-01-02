using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.JiraTableConverter.EmphTextStylers
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
