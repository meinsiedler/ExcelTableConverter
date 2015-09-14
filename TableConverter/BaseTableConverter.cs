using System.Collections.Generic;
using System.Windows.Forms;
using MeTools.ExcelContent;
using MeTools.ExcelContent.Model;

namespace METools.TableConverter
{
  public abstract class BaseTableConverter
  {
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

    private static Dictionary<string, BaseTableConverter> _converters;

    public static Dictionary<string, BaseTableConverter> Converters
    {
      get { return _converters ?? (_converters = new Dictionary<string, BaseTableConverter>()); }
    }

    public static BaseTableConverter CurrentConverter { get; set; }

    public static string GetContent()
    {
      ExcelReader excelReader = ExcelReaderFactory.CreateExcelReader();
      return CurrentConverter.GetConvertedContent(excelReader.GetExcelTable(ExcelConstants.Worksheet, ExcelConstants.Selection));
    }

    /// <summary>
    /// if the converter should be listed in the list of converters,
    /// the converter has to call the AddConverter-Method to add
    /// himself to the list of available converters
    /// </summary>
    /// <param name="converterName"></param>
    /// <param name="converter"></param>
    protected static void AddConverter(string converterName, BaseTableConverter converter)
    {
      if (!Converters.ContainsKey(converterName))
      {
        Converters.Add(converterName, converter);
      }
    }

  }
}
