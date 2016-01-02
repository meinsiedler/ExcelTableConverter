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

    public TableConverterDialog()
    {
      InitializeComponent();

      StartPosition = FormStartPosition.CenterParent;

      ConverterComboBox.Items.AddRange(ConverterProvider.Instance.GetConverterNames().Cast<object>().ToArray());
      if(ConverterComboBox.Items.Count > 0)
      {
        ConverterComboBox.SelectedIndex = 0;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ConverterProvider.Instance.SetCurrentConverter(ConverterComboBox.SelectedItem.ToString());
      _extendedFeaturesUserControl = ConverterProvider.Instance.CurrentConverter.ExtendedFeaturesUserControl;
      extendedFeaturesPanel.Controls.Clear();
      if (_extendedFeaturesUserControl != null)
      {
        extendedFeaturesGroupBox.Visible = true;
        extendedFeaturesGroupBox.Text = string.Format("Extended \"{0}\" Features", ConverterProvider.Instance.CurrentConverter);
        extendedFeaturesPanel.Controls.Add(_extendedFeaturesUserControl);
      }
      else
      {
        extendedFeaturesGroupBox.Visible = false;
      }
      _fileName = string.Empty;
      FilePathTextBox.Text = string.Empty;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_fileName))
      {
        ShowSaveFileDialog();
      }

      if (!string.IsNullOrEmpty(_fileName))
      {
        SaveUtility saveUtility = new SaveUtility(_fileName, ConverterProvider.Instance.GetContent());
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
      if (ConverterProvider.Instance.CurrentConverter != null)
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.AddExtension = true;
        saveFileDialog.Filter = string.Format("{0} files (*.{1})|*.{1}", ConverterProvider.Instance.CurrentConverter,
                                              ConverterProvider.Instance.CurrentConverter.GetFileExtension());
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
      if (ConverterProvider.Instance.CurrentConverter != null)
      {
        Clipboard.SetText(ConverterProvider.Instance.GetContent());
      }
      else
      {
        MessageBox.Show(Resources.ConvertNotSet, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void AboutMenuItem_Click(object sender, EventArgs e)
    {
      new AboutBox().ShowDialog();
    }
  }
}
