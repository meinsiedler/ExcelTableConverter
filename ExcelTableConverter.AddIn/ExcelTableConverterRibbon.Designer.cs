namespace MEExcelTools
{
    partial class ExcelTableConverterRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ExcelTableConverterRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.METoolsTab = this.Factory.CreateRibbonTab();
      this.TableConverterGroup = this.Factory.CreateRibbonGroup();
      this.LatexConverterButton = this.Factory.CreateRibbonButton();
      this.METoolsTab.SuspendLayout();
      this.TableConverterGroup.SuspendLayout();
      // 
      // METoolsTab
      // 
      this.METoolsTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
      this.METoolsTab.ControlId.OfficeId = "TabHome";
      this.METoolsTab.Groups.Add(this.TableConverterGroup);
      this.METoolsTab.Label = "TabHome";
      this.METoolsTab.Name = "METoolsTab";
      // 
      // TableConverterGroup
      // 
      this.TableConverterGroup.Items.Add(this.LatexConverterButton);
      this.TableConverterGroup.Label = "Table Converter";
      this.TableConverterGroup.Name = "TableConverterGroup";
      // 
      // LatexConverterButton
      // 
      this.LatexConverterButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.LatexConverterButton.Image = global::MEExcelTools.Properties.Resources.convert_icon;
      this.LatexConverterButton.Label = "Convert to other table format";
      this.LatexConverterButton.Name = "LatexConverterButton";
      this.LatexConverterButton.ShowImage = true;
      this.LatexConverterButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LatexConverterButton_Click);
      // 
      // ExcelTableConverterRibbon
      // 
      this.Name = "ExcelTableConverterRibbon";
      this.RibbonType = "Microsoft.Excel.Workbook";
      this.Tabs.Add(this.METoolsTab);
      this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.METools_Load);
      this.METoolsTab.ResumeLayout(false);
      this.METoolsTab.PerformLayout();
      this.TableConverterGroup.ResumeLayout(false);
      this.TableConverterGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab METoolsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TableConverterGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LatexConverterButton;
    }

    partial class ThisRibbonCollection
    {
        internal ExcelTableConverterRibbon ExcelTableConverterRibbon
        {
            get { return this.GetRibbon<ExcelTableConverterRibbon>(); }
        }
    }
}
