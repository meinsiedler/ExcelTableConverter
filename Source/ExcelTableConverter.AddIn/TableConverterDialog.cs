using System;
using System.Drawing;
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
      
      StartPosition = FormStartPosition.Manual;

      ConverterComboBox.Items.AddRange(ConverterProvider.Instance.GetConverterNames().Cast<object>().ToArray());
      if(ConverterComboBox.Items.Count > 0)
      {
        ConverterComboBox.SelectedIndex = 0;
      }
    }

    public void SetLocation(Screen screen, Point applicationLocation, double applicationWidth, double applicationHeight)
    {
      const double pointsPerInch = 72.0;
      var pixelFactor = GetDpiX(screen) / pointsPerInch;
      var x = pixelFactor * applicationLocation.X + (pixelFactor * applicationWidth - Width) / 2;
      var y = pixelFactor * applicationLocation.Y + (pixelFactor * applicationHeight - Height) / 2;
      Location = new Point((int)x, (int)y);
    }

    public double GetDpiX(Screen screen)
    {
      uint dpiX;
      uint dpiY;
      screen.GetDpi(DpiType.Effective, out dpiX, out dpiY);
      return Convert.ToDouble(dpiX);
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

    private void TableConverterDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason != CloseReason.UserClosing)
      {
        // close form properly when anything else except the user closes the form (e.g. TaskManger, Application.Exit(), ...)
        return;
      }
        
      Hide();
      e.Cancel = true;
    }
  }
}
