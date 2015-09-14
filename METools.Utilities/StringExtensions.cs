using System;
using System.Globalization;

namespace ExcelTableConverter.Utilities
{
  public static class StringExtensions
  {
    public static bool IsNumeric(this string input, NumberStyles numberStyles, IFormatProvider formatProvider)
    {
      Double temp;
      return Double.TryParse(input, numberStyles, formatProvider, out temp);
    }

    public static bool IsNumericCurrentCulture(this string input, NumberStyles numberStyles)
    {
      return IsNumeric(input, numberStyles, CultureInfo.CurrentCulture);
    }

    public static bool IsNumeric(this string input, IFormatProvider formatProvider)
    {
      return IsNumeric(input, NumberStyles.Any, formatProvider);
    }

    public static bool IsNumericCurrentCulture(this string input)
    {
      return IsNumeric(input, NumberStyles.Any, CultureInfo.CurrentCulture);
    }
  }
}
