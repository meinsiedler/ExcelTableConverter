using System.Collections.Generic;
using System.Windows.Forms;
using ExcelTableConverter.ExcelContent;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.TableConverter
{
  public abstract class BaseTableConverter
  {
    public abstract string ConverterName { get; }
    /// <summary>
    /// the return string of this method will be shown in the user interface
    /// to know the converter which will be used
    /// </summary>
    /// <returns></returns>
    public abstract override string ToString();

    public abstract string GetConvertedContent(Table excelTable);
    public abstract string GetFileExtension();
    public virtual UserControl ExtendedFeaturesUserControl
    {
      get { return null; }
    }
  }
}
