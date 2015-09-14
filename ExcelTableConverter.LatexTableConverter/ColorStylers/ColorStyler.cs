using System;
using System.Drawing;
using System.Globalization;

namespace ExcelTableConverter.LatexTableConverter.ColorStylers
{
  public abstract class ColorStyler
  {
    protected string GetDoubleRgbValues(Color color)
    {
      var r = Get0To1From0To255(color.R);
      var g = Get0To1From0To255(color.G);
      var b = Get0To1From0To255(color.B);

      return GetConcatedRgbValues(r, g, b);
    }

    private double Get0To1From0To255(int value)
    {
      return Math.Round(1.0 / 255.0 * value, 2);
    }

    private string GetConcatedRgbValues(double r, double g, double b)
    {
      string str = AppendWithComma(r);
      str += AppendWithComma(g);
      str += AppendWithoutComma(b);
      return str;
    }

    private string AppendWithComma(double value)
    {
      return AppendWithoutComma(value) + ",";
    }

    private string AppendWithoutComma(double value)
    {
      return value.ToString(CultureInfo.GetCultureInfo("en-US"));
    }

    public string Colorize(Color color, string text)
    {
      if (color != ExcludeColor)
        return ColorizeCommand(color, text);
      return text;
    }

    protected abstract string ColorizeCommand(Color color, string text);

    protected abstract Color ExcludeColor { get; }
  }
}
