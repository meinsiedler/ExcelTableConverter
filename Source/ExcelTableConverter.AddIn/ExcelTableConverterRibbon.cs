using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelTableConverter.AddIn
{
  public partial class ExcelTableConverterRibbon
  {
    private TableConverterDialog _tableConverterDialog;
    private bool _isDialogShownFirstTime = true;

    public TableConverterDialog TableConverterDialog
    {
      get { return _tableConverterDialog ?? (_tableConverterDialog = new TableConverterDialog()); }
    }

    private void ExcelTableConveterRibbon_Load(object sender, RibbonUIEventArgs e)
    {
      ConverterProvider.Instance.InitTableConverters();
    }

    private void LatexConverterButton_Click(object sender, RibbonControlEventArgs e)
    {
      IntPtr hwnd = new IntPtr(Globals.ThisAddIn.Application.Hwnd);

      if (_isDialogShownFirstTime)
      {
        TableConverterDialog.SetLocation(
          Screen.FromHandle(hwnd),
          new Point((int)Globals.ThisAddIn.Application.Left, (int)Globals.ThisAddIn.Application.Application.Top),
          Globals.ThisAddIn.Application.Width,
          Globals.ThisAddIn.Application.Height);
        _isDialogShownFirstTime = false;
      }

      TableConverterDialog.Show(new Win32Window(hwnd));
    }
  }
}
