namespace ExcelTableConverter.JiraTableConverter
{
  partial class ExtendedJiraFeaturesControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.FirstRowIsHeader = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // FirstRowIsHeader
      // 
      this.FirstRowIsHeader.AutoSize = true;
      this.FirstRowIsHeader.Location = new System.Drawing.Point(4, 4);
      this.FirstRowIsHeader.Name = "FirstRowIsHeader";
      this.FirstRowIsHeader.Size = new System.Drawing.Size(111, 17);
      this.FirstRowIsHeader.TabIndex = 0;
      this.FirstRowIsHeader.Text = "First row is header";
      this.FirstRowIsHeader.UseVisualStyleBackColor = true;
      // 
      // ExtendedJiraFeaturesControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.FirstRowIsHeader);
      this.Name = "ExtendedJiraFeaturesControl";
      this.Size = new System.Drawing.Size(118, 24);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox FirstRowIsHeader;
  }
}
