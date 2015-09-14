using METools.TableConverter;
using MeTools.ExcelContent;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter
{
  public class TestConverter : BaseTableConverter
  {

    public TestConverter()
    {
      AddConverter(ConverterName(), this);
    }

    private string ConverterName()
    {
      return "TestConverter";
    }

    public override string ToString()
    {
      return ConverterName();
    }

    public override string GetConvertedContent(Table excelTable)
    {
      return "Test Converter Content";
    }

    public override string GetFileExtension()
    {
      return "test";
    }
  }
}
