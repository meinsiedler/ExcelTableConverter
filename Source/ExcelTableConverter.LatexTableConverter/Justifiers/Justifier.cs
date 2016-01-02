using System;

namespace ExcelTableConverter.LatexTableConverter.Justifiers
{
  public abstract class Justifier
  {
    public string Justify(string value, bool useBorders)
    {
      return SingleMulticolumn(GetAlignment(), value, useBorders);
    }

    protected string SingleMulticolumn(char align, string value, bool useBorders)
    {
      if(align != 'l' && align != 'c' && align != 'r')
        throw new ArgumentException("only 'l', 'c' or 'r' align allowed");
      return string.Format("\\multicolumn{{1}}{{{2}{0}{2}}}{{{1}}}", align, value, useBorders ? "|" : string.Empty);
    }

    public abstract char GetAlignment();
  }
}
