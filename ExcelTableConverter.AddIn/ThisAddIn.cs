using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.TableConverter;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;


namespace ExcelTableConverter.AddIn
{
  public partial class ThisAddIn
  {

    private Office.CommandBar _cellbar;
    private Office.CommandBarButton _button;

    private void ThisAddIn_Startup(object sender, EventArgs e)
    {
      ExcelConstants.Worksheet = (Excel.Worksheet) Globals.ThisAddIn.Application.ActiveSheet;
      ExcelConstants.Selection = new Selection {ColumnCount = 1, RowCount = 1, StartColumn = 1, StartRow = 1};

      _cellbar = Application.CommandBars["Cell"];
      _button = (Office.CommandBarButton)_cellbar.FindControl(Office.MsoControlType.msoControlButton, 0, "MYRIGHTCLICKMENU", Missing.Value, Missing.Value);
      if (_button == null)
      {
        // add the button
        _button = (Office.CommandBarButton)_cellbar.Controls.Add(Office.MsoControlType.msoControlButton, Missing.Value, Missing.Value, _cellbar.Controls.Count, true);
        _button.Caption = "Quick Convert";
        _button.BeginGroup = true;
        _button.DescriptionText = "Uses the actual ExcelTableConverterRibbon Settings to convert the excel table";
        _button.Picture = ConvertImage.GetIPictureDispImage(Properties.Resources.convert_icon_small);
        _button.Click += QuickConvertButton_Click;
      }

      BaseTableConverter.CurrentConverter = BaseTableConverter.Converters.First().Value;

      Globals.ThisAddIn.Application.SheetSelectionChange += ApplicationOnSheetSelectionChange;
      Globals.ThisAddIn.Application.WorkbookActivate += ApplicationOnWorkbookActivate;
      Globals.ThisAddIn.Application.SheetActivate += ApplicationOnSheetActivate;
    }

    private void ApplicationOnSheetSelectionChange(object sh, Excel.Range target)
    {
      ExcelConstants.Selection = new Selection
        {
          ColumnCount = target.Columns.Count,
          RowCount = target.Rows.Count,
          StartColumn = target.Column,
          StartRow = target.Row
        };
      
    }

    private void ApplicationOnWorkbookActivate(Excel.Workbook wb)
    {
      ExcelConstants.Worksheet = (Excel.Worksheet)wb.ActiveSheet;
    }

    private void ApplicationOnSheetActivate(object sh)
    {
      ExcelConstants.Worksheet = (Excel.Worksheet)sh;
    }


    private void ThisAddIn_Shutdown(object sender, EventArgs e)
    {
      Application.CommandBars["Cell"].Reset();
    }

    private void QuickConvertButton_Click(Office.CommandBarButton cmdBarbutton, ref bool cancel)
    {
      Clipboard.SetText(BaseTableConverter.GetContent());
    }

    

    #region VSTO generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InternalStartup()
    {
        Startup += ThisAddIn_Startup;
        Shutdown += ThisAddIn_Shutdown;
    }
        
    #endregion
  }
}
