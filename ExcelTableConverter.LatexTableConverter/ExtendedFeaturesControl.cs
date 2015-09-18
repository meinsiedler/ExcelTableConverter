using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelTableConverter.LatexTableConverter
{
  public partial class ExtendedFeaturesControl : UserControl
  {
    public ExtendedFeaturesControl(bool addTableEnvironment, bool replaceConstants, bool useBorders, bool useColors, bool autoJustify)
    {
      InitializeComponent();

      AddTableEnvironment.Checked = addTableEnvironment;
      ReplaceSpecialChars.Checked = replaceConstants;
      
      UseBorders.Checked = useBorders;
      NoHLines.Checked = true;
      BorderPackagesWarningPicture.Visible = FullBorderConfig.Checked;
      SetEnabledDisabledWarningPicture(BorderPackagesWarningPicture, FullBorderConfig.Enabled);
      
      UseColors.Checked = useColors;
      ColorPackageWarningPicture.Visible = UseColors.Checked;
      SetEnabledDisabledWarningPicture(ColorPackageWarningPicture, UseColors.Enabled);

      AutoJustify.Checked = autoJustify;

      ColorPackageWarningPicture.Visible = UseColors.Checked;
    }

    private void SetEnabledDisabledWarningPicture(PictureBox pictureBox, bool value)
    {
      pictureBox.Image = value ? Properties.Resources.attention : Properties.Resources.attention_gray;
    }

    public bool AddTableEnvironmentChecked()
    {
      return AddTableEnvironment.Checked;
    }

    public bool ReplaceSpecialCharsChecked()
    {
      return ReplaceSpecialChars.Checked;
    }

    public bool UseBordersChecked()
    {
      return UseBorders.Checked;
    }

    public bool NoHlinesChecked()
    {
      return UseBordersChecked() && NoHLines.Checked;
    }

    public bool AddHlineChecked()
    {
      return UseBordersChecked() && AddHLines.Checked;
    }

    public bool FullBorderConfigChecked()
    {
      return UseBordersChecked() && FullBorderConfig.Checked;
    }

    public bool UseColorsChecked()
    {
      return UseColors.Checked;
    }

    public bool AutoJustifyChecked()
    {
      return AutoJustify.Checked;
    }
    
    public string TableCaptionTextBoxText()
    {
      return TableCaptionTextBox.Text;
    }

    private void UseColors_CheckedChanged(object sender, EventArgs e)
    {
      ColorPackageWarningPicture.Visible = UseColors.Checked;
    }

    private void UseBorders_CheckedChanged(object sender, EventArgs e)
    {
      foreach (var radioButton in GetBorderRadioButtons())
      {
        radioButton.Enabled = UseBorders.Checked;
      }
      BorderPackagesWarningPicture.Enabled = UseBorders.Checked;
      SetEnabledDisabledWarningPicture(BorderPackagesWarningPicture, FullBorderConfig.Enabled);
    }

    private IEnumerable<RadioButton> GetBorderRadioButtons()
    {
      return new List<RadioButton> {NoHLines, AddHLines, FullBorderConfig};
    }

    private void FullBorderConfig_CheckedChanged(object sender, EventArgs e)
    {
      BorderPackagesWarningPicture.Visible = FullBorderConfig.Checked;
    } 

  }
}
