namespace MeTools.ExcelContent.ExtractorDecorators
{
  public abstract class ExtractorDecorator : ExcelReader
  {
    private ExcelReader _excelReader;

    protected ExtractorDecorator(ExcelReader excelReader)
    {
      _excelReader = excelReader;
    }
  }
}
