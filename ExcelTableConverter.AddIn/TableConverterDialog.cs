using System;
using System.Linq;
using System.Windows.Forms;
using ExcelTableConverter.AddIn.Properties;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.AddIn
{
  public partial class TableConverterDialog : Form
  {
    private string _fileName;

    private UserControl _extendedFeaturesUserControl;


    private BaseTableConverter CurrentConverter
    {
      get { return BaseTableConverter.CurrentConverter; }
      set
      {
        BaseTableConverter.CurrentConverter = value;
        _extendedFeaturesUserControl = BaseTableConverter.CurrentConverter.ExtendedFeaturesUserControl;
        extendedFeaturesPanel.Controls.Clear();
        if (_extendedFeaturesUserControl != null)
        {
          extendedFeaturesGroupBox.Visible = true;
          extendedFeaturesGroupBox.Text = string.Format("Extended \"{0}\" Features", CurrentConverter);
          extendedFeaturesPanel.Controls.Add(_extendedFeaturesUserControl);
        }
        else
        {
          extendedFeaturesGroupBox.Visible = false;
        }
      }
    }

    public TableConverterDialog()
    {
      InitializeComponent();

      StartPosition = FormStartPosition.CenterParent;

      ConverterComboBox.Items.AddRange(ConverterNames());
      if(ConverterComboBox.Items.Count > 0)
      {
        ConverterComboBox.SelectedIndex = 0;
      }

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      CurrentConverter = BaseTableConverter.Converters[ConverterComboBox.SelectedItem.ToString()];
      _fileName = string.Empty;
      FilePathTextBox.Text = string.Empty;
    }

    private object[] ConverterNames()
    {
      return BaseTableConverter.Converters.Select(converter => converter.Key).Cast<object>().ToArray();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_fileName))
      {
        ShowSaveFileDialog();
      }

      if (!string.IsNullOrEmpty(_fileName))
      {
        SaveUtility saveUtility = new SaveUtility(_fileName, BaseTableConverter.GetContent());
        saveUtility.SaveFile();
        MessageBox.Show(Resources.ConvertingCompleted, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }



    private void BrowseButton_Click(object sender, EventArgs e)
    {
      ShowSaveFileDialog();
    }

    private void ShowSaveFileDialog()
    {
      if (CurrentConverter != null)
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.AddExtension = true;
        saveFileDialog.Filter = string.Format("{0} files (*.{1})|*.{1}", CurrentConverter,
                                              CurrentConverter.GetFileExtension());
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.CreatePrompt = false;
        saveFileDialog.OverwritePrompt = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          _fileName = saveFileDialog.FileName;
          FilePathTextBox.Text = _fileName;
        }
      }
      else
      {
        MessageBox.Show(Resources.ConvertNotSet, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void copyToClipboard_Click(object sender, EventArgs e)
    {
      if (CurrentConverter != null)
      {
        Clipboard.SetText(BaseTableConverter.GetContent());
      }
      else
      {
        MessageBox.Show(Resources.ConvertNotSet, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    

  }
}
