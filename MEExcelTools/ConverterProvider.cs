namespace MEExcelTools
{
  public class ConverterProvider
  {
    public static IConverterLoader GetConverter()
    {
      return new DefaultConverterLoader();
    }
  }
}
