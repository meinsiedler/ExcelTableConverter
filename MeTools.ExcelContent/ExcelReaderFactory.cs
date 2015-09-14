using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.ExtractorDecorators;

namespace MeTools.ExcelContent
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
