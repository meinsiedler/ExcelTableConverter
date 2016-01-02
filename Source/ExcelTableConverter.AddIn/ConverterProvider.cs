using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.AddIn
{
  public class ConverterProvider
  {
    private static ConverterProvider _instance;

    public static ConverterProvider Instance
    {
      get { return _instance ?? (_instance = new ConverterProvider()); }
    }

    private bool _initialized;
    private readonly Dictionary<string, BaseTableConverter> _converters = new Dictionary<string, BaseTableConverter>();
    public BaseTableConverter CurrentConverter { get; private set; }

    private ConverterProvider()
    {
      InitTableConverters();
    }

    public void SetCurrentConverter(string converterName)
    {
      BaseTableConverter converter;
      if (_converters.TryGetValue(converterName, out converter))
      {
        CurrentConverter = converter;
      }
    }

    public void InitTableConverters()
    {
      if (_initialized)
      {
        return;
      }

      foreach (var converter in GetConverterLoader().GetConverters())
      {
        _converters.Add(converter.ConverterName, converter);
      }
      if (_converters.Any())
      {
        CurrentConverter = _converters.First().Value;  
      }
      _initialized = true;
    }

    public string GetContent()
    {
      ExcelReader excelReader = ExcelReaderFactory.CreateExcelReader();
      return CurrentConverter.GetConvertedContent(excelReader.GetExcelTable(ExcelProperties.Instance.Worksheet, ExcelProperties.Instance.Selection));
    }

    public IEnumerable<string> GetConverterNames()
    {
      return _converters.Keys;
    }

    private IConverterLoader GetConverterLoader()
    {
      return new ReflectionConverterLoader();
    }
  }
}
