namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public abstract class ExtractorDecorator : ExcelReader
  {
    protected readonly ExcelReader ExcelReader;

    protected ExtractorDecorator(ExcelReader excelReader)
    {
      ExcelReader = excelReader;
    }
  }
}
