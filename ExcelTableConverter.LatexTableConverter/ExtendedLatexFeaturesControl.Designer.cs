namespace ExcelTableConverter.LatexTableConverter
{
  partial class ExtendedLatexFeaturesControl
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
      this.components = new System.ComponentModel.Container();
      this.TableCaptionTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.AddTableEnvironment = new System.Windows.Forms.CheckBox();
      this.ReplaceSpecialChars = new System.Windows.Forms.CheckBox();
      this.UseColors = new System.Windows.Forms.CheckBox();
      this.PackageWarningToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.ColorPackageWarningPicture = new System.Windows.Forms.PictureBox();
      this.BorderPackagesWarningPicture = new System.Windows.Forms.PictureBox();
      this.AutoJustify = new System.Windows.Forms.CheckBox();
      this.UseBorders = new System.Windows.Forms.CheckBox();
      this.NoHLines = new System.Windows.Forms.RadioButton();
      this.AddHLines = new System.Windows.Forms.RadioButton();
      this.FullBorderConfig = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.ColorPackageWarningPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BorderPackagesWarningPicture)).BeginInit();
      this.SuspendLayout();
      // 
      // TableCaptionTextBox
      // 
      this.TableCaptionTextBox.Location = new System.Drawing.Point(3, 22);
      this.TableCaptionTextBox.Name = "TableCaptionTextBox";
      this.TableCaptionTextBox.Size = new System.Drawing.Size(218, 20);
      this.TableCaptionTextBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Table Caption:";
      // 
      // AddTableEnvironment
      // 
      this.AddTableEnvironment.AutoSize = true;
      this.AddTableEnvironment.Location = new System.Drawing.Point(3, 48);
      this.AddTableEnvironment.Name = "AddTableEnvironment";
      this.AddTableEnvironment.Size = new System.Drawing.Size(132, 17);
      this.AddTableEnvironment.TabIndex = 2;
      this.AddTableEnvironment.Text = "Add table environment";
      this.AddTableEnvironment.UseVisualStyleBackColor = true;
      // 
      // ReplaceSpecialChars
      // 
      this.ReplaceSpecialChars.AutoSize = true;
      this.ReplaceSpecialChars.Location = new System.Drawing.Point(3, 71);
      this.ReplaceSpecialChars.Name = "ReplaceSpecialChars";
      this.ReplaceSpecialChars.Size = new System.Drawing.Size(218, 17);
      this.ReplaceSpecialChars.TabIndex = 3;
      this.ReplaceSpecialChars.Text = "Replace special LaTeX chars (\'%\', \'_\', ...)";
      this.ReplaceSpecialChars.UseVisualStyleBackColor = true;
      // 
      // UseColors
      // 
      this.UseColors.AutoSize = true;
      this.UseColors.Location = new System.Drawing.Point(3, 94);
      this.UseColors.Name = "UseColors";
      this.UseColors.Size = new System.Drawing.Size(138, 17);
      this.UseColors.TabIndex = 5;
      this.UseColors.Text = "Allow text- and fill colors";
      this.UseColors.UseVisualStyleBackColor = true;
      this.UseColors.CheckedChanged += new System.EventHandler(this.UseColors_CheckedChanged);
      // 
      // PackageWarningToolTip
      // 
      this.PackageWarningToolTip.AutoPopDelay = 5000;
      this.PackageWarningToolTip.InitialDelay = 100;
      this.PackageWarningToolTip.ReshowDelay = 100;
      // 
      // ColorPackageWarningPicture
      // 
      this.ColorPackageWarningPicture.Image = global::ExcelTableConverter.LatexTableConverter.Properties.Resources.attention;
      this.ColorPackageWarningPicture.Location = new System.Drawing.Point(147, 94);
      this.ColorPackageWarningPicture.Name = "ColorPackageWarningPicture";
      this.ColorPackageWarningPicture.Size = new System.Drawing.Size(21, 17);
      this.ColorPackageWarningPicture.TabIndex = 6;
      this.ColorPackageWarningPicture.TabStop = false;
      this.PackageWarningToolTip.SetToolTip(this.ColorPackageWarningPicture, "package \'xcolor\' with optional parameter \'table\'\r\nis required to use this functio" +
        "nality.");
      // 
      // BorderPackagesWarningPicture
      // 
      this.BorderPackagesWarningPicture.Image = global::ExcelTableConverter.LatexTableConverter.Properties.Resources.attention;
      this.BorderPackagesWarningPicture.Location = new System.Drawing.Point(191, 212);
      this.BorderPackagesWarningPicture.Name = "BorderPackagesWarningPicture";
      this.BorderPackagesWarningPicture.Size = new System.Drawing.Size(19, 17);
      this.BorderPackagesWarningPicture.TabIndex = 12;
      this.BorderPackagesWarningPicture.TabStop = false;
      this.PackageWarningToolTip.SetToolTip(this.BorderPackagesWarningPicture, "packages \'hhline\' and \'arydshln\'\r\nare required to use this functionality.");
      // 
      // AutoJustify
      // 
      this.AutoJustify.AutoSize = true;
      this.AutoJustify.Location = new System.Drawing.Point(3, 117);
      this.AutoJustify.Name = "AutoJustify";
      this.AutoJustify.Size = new System.Drawing.Size(171, 17);
      this.AutoJustify.TabIndex = 7;
      this.AutoJustify.Text = "Auto-justify based on data type";
      this.AutoJustify.UseVisualStyleBackColor = true;
      // 
      // UseBorders
      // 
      this.UseBorders.AutoSize = true;
      this.UseBorders.Location = new System.Drawing.Point(3, 141);
      this.UseBorders.Name = "UseBorders";
      this.UseBorders.Size = new System.Drawing.Size(83, 17);
      this.UseBorders.TabIndex = 8;
      this.UseBorders.Text = "Use borders";
      this.UseBorders.UseVisualStyleBackColor = true;
      this.UseBorders.CheckedChanged += new System.EventHandler(this.UseBorders_CheckedChanged);
      // 
      // NoHLines
      // 
      this.NoHLines.AutoSize = true;
      this.NoHLines.Checked = true;
      this.NoHLines.Location = new System.Drawing.Point(21, 164);
      this.NoHLines.Name = "NoHLines";
      this.NoHLines.Size = new System.Drawing.Size(111, 17);
      this.NoHLines.TabIndex = 9;
      this.NoHLines.TabStop = true;
      this.NoHLines.Text = "No horizontal lines";
      this.NoHLines.UseVisualStyleBackColor = true;
      // 
      // AddHLines
      // 
      this.AddHLines.AutoSize = true;
      this.AddHLines.Location = new System.Drawing.Point(21, 188);
      this.AddHLines.Name = "AddHLines";
      this.AddHLines.Size = new System.Drawing.Size(144, 17);
      this.AddHLines.TabIndex = 10;
      this.AddHLines.TabStop = true;
      this.AddHLines.Text = "Add \\hline after each line";
      this.AddHLines.UseVisualStyleBackColor = true;
      // 
      // FullBorderConfig
      // 
      this.FullBorderConfig.AutoSize = true;
      this.FullBorderConfig.Location = new System.Drawing.Point(21, 212);
      this.FullBorderConfig.Name = "FullBorderConfig";
      this.FullBorderConfig.Size = new System.Drawing.Size(163, 17);
      this.FullBorderConfig.TabIndex = 11;
      this.FullBorderConfig.TabStop = true;
      this.FullBorderConfig.Text = "Allow full border configuration";
      this.FullBorderConfig.UseVisualStyleBackColor = true;
      this.FullBorderConfig.CheckedChanged += new System.EventHandler(this.FullBorderConfig_CheckedChanged);
      // 
      // ExtendedFeaturesControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.BorderPackagesWarningPicture);
      this.Controls.Add(this.FullBorderConfig);
      this.Controls.Add(this.AddHLines);
      this.Controls.Add(this.NoHLines);
      this.Controls.Add(this.UseBorders);
      this.Controls.Add(this.AutoJustify);
      this.Controls.Add(this.ColorPackageWarningPicture);
      this.Controls.Add(this.UseColors);
      this.Controls.Add(this.ReplaceSpecialChars);
      this.Controls.Add(this.AddTableEnvironment);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TableCaptionTextBox);
      this.Name = "ExtendedFeaturesControl";
      this.Size = new System.Drawing.Size(224, 236);
      ((System.ComponentModel.ISupportInitialize)(this.ColorPackageWarningPicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BorderPackagesWarningPicture)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TableCaptionTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox AddTableEnvironment;
    private System.Windows.Forms.CheckBox ReplaceSpecialChars;
    private System.Windows.Forms.CheckBox UseColors;
    private System.Windows.Forms.PictureBox ColorPackageWarningPicture;
    private System.Windows.Forms.ToolTip PackageWarningToolTip;
    private System.Windows.Forms.CheckBox AutoJustify;
    private System.Windows.Forms.CheckBox UseBorders;
    private System.Windows.Forms.RadioButton NoHLines;
    private System.Windows.Forms.RadioButton AddHLines;
    private System.Windows.Forms.RadioButton FullBorderConfig;
    private System.Windows.Forms.PictureBox BorderPackagesWarningPicture;


  }
}
