namespace ExcelTableConverter.Interop.InteropConverter
{
  public interface IInteropConverter<in TInterop, out TResult>
  {
    TResult ConvertFromInterop(TInterop obj);
  }
}
