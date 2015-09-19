using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.Model.InteropWrappers
{
  public class BorderInteropWrapper : IBorder
  {
    private readonly Border _interopBorder;

    public BorderInteropWrapper(Border interopBorder)
    {
      _interopBorder = interopBorder;
    }

    public BorderInformation.BorderStyleEnum LineStyle
    {
      get
      {
        if (_interopBorder.LineStyle == (int)XlLineStyle.xlContinuous)
          return BorderInformation.BorderStyleEnum.Solid;
        if (_interopBorder.LineStyle == (int)XlLineStyle.xlDash)
          return BorderInformation.BorderStyleEnum.Dashed;
        if (_interopBorder.LineStyle == (int)XlLineStyle.xlDot)
          return BorderInformation.BorderStyleEnum.Dotted;
        if (_interopBorder.LineStyle == (int)XlLineStyle.xlDouble)
          return BorderInformation.BorderStyleEnum.DoubleLineSolid;

        return BorderInformation.BorderStyleEnum.None;
      }
    }

    public BorderInformation.ThicknessEnum Weight
    {
      get
      {
        if (_interopBorder.Weight == (int)XlBorderWeight.xlHairline)
          return BorderInformation.ThicknessEnum.Hairline;
        if (_interopBorder.Weight == (int)XlBorderWeight.xlThin)
          return BorderInformation.ThicknessEnum.Thin;
        if (_interopBorder.Weight == (int)XlBorderWeight.xlMedium)
          return BorderInformation.ThicknessEnum.Medium;
        if (_interopBorder.Weight == (int)XlBorderWeight.xlThick)
          return BorderInformation.ThicknessEnum.Thick;

        return BorderInformation.ThicknessEnum.Hairline;
      }
    }
  }
}
