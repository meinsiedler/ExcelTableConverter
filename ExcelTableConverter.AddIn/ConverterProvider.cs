namespace ExcelTableConverter.AddIn
{
  public class ConverterProvider
  {
    public static IConverterLoader GetConverter()
    {
      return new DefaultConverterLoader();
    }
  }
}
