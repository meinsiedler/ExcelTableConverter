using System.Collections.Generic;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.AddIn
{
  public interface IConverterLoader
  {
    IEnumerable<BaseTableConverter> GetConverters();
  }
}
