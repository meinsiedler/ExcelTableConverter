namespace ExcelTableConverter.ExcelContent.InteropConverter
{
  public interface IInteropConverter<in TInterop, out TResult>
  {
    TResult ConvertFromInterop(TInterop obj);
  }
}
