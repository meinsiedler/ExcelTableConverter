using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelTableConverter.LatexTableConverter
{
  public partial class ExtendedLatexFeaturesControl : UserControl
  {
    public ExtendedLatexFeaturesControl(bool addTableEnvironment, bool replaceConstants, bool useBorders, bool useColors, bool autoJustify)
    {
      InitializeComponent();

      AddTableEnvironment.Checked = addTableEnvironment;
      ReplaceSpecialChars.Checked = replaceConstants;
      
      UseBorders.Checked = useBorders;
      NoHLines.Checked = true;
      SetBorderWarningPictures();
      
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

    public bool HighQualityTableChecked()
    {
      return UseBordersChecked() && HighQualityTable.Checked;
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
      SetBorderWarningPictures();
    }

    private IEnumerable<RadioButton> GetBorderRadioButtons()
    {
      return new List<RadioButton> {NoHLines, AddHLines, FullBorderConfig, HighQualityTable};
    }

    private void FullBorderConfig_CheckedChanged(object sender, EventArgs e)
    {
      FullBorderConfigPackagesWarningPicture.Visible = FullBorderConfig.Checked;
    }

    private void HighQualityTable_CheckedChanged(object sender, EventArgs e)
    {
      HighQualityTablePackagesWarningPicture.Visible = HighQualityTable.Checked;
    }

    private void SetBorderWarningPictures()
    {
      FullBorderConfigPackagesWarningPicture.Visible = FullBorderConfig.Checked;
      SetEnabledDisabledWarningPicture(FullBorderConfigPackagesWarningPicture, FullBorderConfig.Enabled);
      HighQualityTablePackagesWarningPicture.Visible = HighQualityTable.Checked;
      SetEnabledDisabledWarningPicture(HighQualityTablePackagesWarningPicture, HighQualityTable.Enabled);
    }
  }
}
