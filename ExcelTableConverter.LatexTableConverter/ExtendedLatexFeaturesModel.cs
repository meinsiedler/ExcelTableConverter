using System.Windows.Forms;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.LatexTableConverter
{
  public class ExtendedLatexFeaturesModel : IExtendedLatexFeaturesModel
  {
    public string TableName
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).TableCaptionTextBoxText(); }
    }

    public bool AddTableEnvironment
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).AddTableEnvironmentChecked(); }
    }

    public bool ReplaceConstants
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).ReplaceSpecialCharsChecked(); }
    }

    public bool UseBorders
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).UseBordersChecked(); }
    }

    public bool NoHlines
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).NoHlinesChecked(); }
    }

    public bool AddHlines
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).AddHlineChecked(); }
    }

    public bool FullBorderConfig
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).FullBorderConfigChecked(); }
    }

    public bool UseColors
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).UseColorsChecked(); }
    }

    public bool AutoJustify
    {
      get { return ((ExtendedLatexFeaturesControl) BoundExtendedFeaturesUserControl).AutoJustifyChecked(); }
    }

    private readonly ExtendedLatexFeaturesControl _featuresControl;

    public UserControl BoundExtendedFeaturesUserControl
    {
      get { return _featuresControl; }
    }

    public ExtendedLatexFeaturesModel()
    {
      _featuresControl = new ExtendedLatexFeaturesControl(true, true, true, true, true);
    }

  }
}
