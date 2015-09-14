using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using METools.TableConverter;


namespace METools.LatexTableConverter
{
  public class ExtendedFeaturesModel : IExtendedFeaturesModel
  {
    public string TableName
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).TableCaptionTextBoxText(); }
    }

    public bool AddTableEnvironment
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).AddTableEnvironmentChecked(); }
    }

    public bool ReplaceConstants
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).ReplaceSpecialCharsChecked(); }
    }

    public bool UseBorders
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).UseBordersChecked(); }
    }

    public bool NoHlines
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).NoHlinesChecked(); }
    }

    public bool AddHline
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).AddHlineChecked(); }
    }

    public bool FullBorderConfig
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).FullBorderConfigChecked(); }
    }

    public bool UseColors
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).UseColorsChecked(); }
    }

    public bool AutoJustify
    {
      get { return ((ExtendedFeaturesControl) BoundExtendedFeaturesUserControl).AutoJustifyChecked(); }
    }

    private readonly ExtendedFeaturesControl _featuresControl;

    public UserControl BoundExtendedFeaturesUserControl
    {
      get { return _featuresControl; }
    }

    public ExtendedFeaturesModel()
    {
      _featuresControl = new ExtendedFeaturesControl(true, true, true, true, true);
    }

  }
}
