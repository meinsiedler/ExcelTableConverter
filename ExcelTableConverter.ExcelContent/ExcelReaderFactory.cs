using ExcelTableConverter.ExcelContent.ExtractorDecorators;

namespace ExcelTableConverter.ExcelContent
{
  public class ExcelReaderFactory
  {
    public static ExcelReader CreateExcelReader()
    {
      return
        new BorderExtractor(
          new FillColorExtractor(
            new TextColorExtractor(
              new HorizontalAlignmentExtractor(
                new EmphasisExtractor(
                  new TextExtractor(
                    new ExcelExtractor()))))));
    }
  }
}
