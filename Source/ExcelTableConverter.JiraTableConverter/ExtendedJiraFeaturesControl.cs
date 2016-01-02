using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelTableConverter.JiraTableConverter
{
  public partial class ExtendedJiraFeaturesControl : UserControl
  {
    public ExtendedJiraFeaturesControl(bool firstRowIsHeader)
    {
      InitializeComponent();

      FirstRowIsHeader.Checked = firstRowIsHeader;
    }

    public bool FirstRowIsHeaderChecked()
    {
      return FirstRowIsHeader.Checked;
    }
  }
}
