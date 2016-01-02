namespace ExcelTableConverter.ExcelContent.Model
{
  public class ExcelProperties
  {
    private static ExcelProperties _instance;

    public static ExcelProperties Instance
    {
      get { return _instance ?? (_instance = new ExcelProperties()); }
    }

    private ExcelProperties() { }

    public IWorksheet Worksheet { get; set; }
    public Selection Selection { get; set; }
  }
}
