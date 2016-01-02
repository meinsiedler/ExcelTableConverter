using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTableConverter.Utilities
{
  public static class ArgumentUtility
  {
    public static void EnsureNotNull(object value, string paramName)
    {
      if (value == null)
      {
        throw new ArgumentNullException(paramName);
      }
    }

    public static void EnsureCondition<T>(T value, Predicate<T> predicate, string paramName)
    {
      if (!predicate(value))
      {
        throw new ArgumentException("parameter does not pass predicate", paramName);
      }
    }
  }
}
