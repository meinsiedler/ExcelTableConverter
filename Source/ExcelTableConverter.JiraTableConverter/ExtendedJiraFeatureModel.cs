using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelTableConverter.JiraTableConverter
{
  public class ExtendedJiraFeatureModel : IExtendedJiraFeatureModel
  {
    private readonly ExtendedJiraFeaturesControl _featuresControl;

    public ExtendedJiraFeatureModel()
    {
      _featuresControl = new ExtendedJiraFeaturesControl(firstRowIsHeader:false);
    }

    public bool FirstRowIsHeader
    {
      get { return _featuresControl.FirstRowIsHeaderChecked(); }
    }

    public UserControl BoundExtendedFeaturesUserControl
    {
      get { return _featuresControl; }
    }
  }
}
