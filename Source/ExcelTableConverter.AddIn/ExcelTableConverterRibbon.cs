using Microsoft.Office.Tools.Ribbon;

namespace ExcelTableConverter.AddIn
{
  public partial class ExcelTableConverterRibbon
  {
    private TableConverterDialog _tableConverterDialog;

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
      TableConverterDialog.ShowDialog();
    }

  }
}
