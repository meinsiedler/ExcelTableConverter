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

      ConverterProvider.GetConverter().Load();

      /* TODO: xml file erstellen (oder irgend eine andere art von konfiguration), wo nur der type des converters
       * drinnensteht und anhand von diesem wird die AddConverter Methode aufgerufen mit dem Type
       * erst wenn es zum konvertieren mit dem ausgewählten type kommt, wird eine Instanz des Types erstellt,
       * vorher ist die Instanz nicht nötig und man müsste für jeden Type beim Startup eine Instanz erstellen,
       * evtl. auch ConverterName Methode statisch machen, wenn man den namen nicht im xml hardcoden will, sondern
       * man liest den namen gleich von der klasse aus
       */
    }

    private void LatexConverterButton_Click(object sender, RibbonControlEventArgs e)
    {
      TableConverterDialog.ShowDialog();
    }

  }
}
