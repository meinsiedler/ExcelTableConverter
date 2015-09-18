using System;

namespace ExcelTableConverter.LatexTableConverter.Justifiers
{
  public abstract class Justifier
  {
    public string Justify(string value)
    {
      return SingleMulticolumn(GetAlignment(), value);
    }

    protected string SingleMulticolumn(char align, string value)
    {
      if(align != 'l' && align != 'c' && align != 'r')
        throw new ArgumentException("only 'l', 'c' or 'r' align allowed");
      return string.Format("\\multicolumn{{1}}{{|{0}|}}{{{1}}}", align, value);
    }

    public abstract char GetAlignment();
  }
}
