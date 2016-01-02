namespace ExcelTableConverter.AddIn
{
  partial class TableConverterDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableConverterDialog));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ConverterComboBox = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.BrowseButton = new System.Windows.Forms.Button();
      this.FilePathTextBox = new System.Windows.Forms.TextBox();
      this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.copyToClipboard = new System.Windows.Forms.Button();
      this.SaveButton = new System.Windows.Forms.Button();
      this.extendedFeaturesGroupBox = new System.Windows.Forms.GroupBox();
      this.extendedFeaturesPanel = new System.Windows.Forms.Panel();
      this.MenuStrip = new System.Windows.Forms.MenuStrip();
      this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.extendedFeaturesGroupBox.SuspendLayout();
      this.MenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ConverterComboBox);
      this.groupBox1.Location = new System.Drawing.Point(14, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 3);
      this.groupBox1.Size = new System.Drawing.Size(259, 52);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Convert to...";
      // 
      // ConverterComboBox
      // 
      this.ConverterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ConverterComboBox.FormattingEnabled = true;
      this.ConverterComboBox.Location = new System.Drawing.Point(7, 20);
      this.ConverterComboBox.Name = "ConverterComboBox";
      this.ConverterComboBox.Size = new System.Drawing.Size(246, 21);
      this.ConverterComboBox.TabIndex = 0;
      this.ConverterComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.BrowseButton);
      this.groupBox2.Controls.Add(this.FilePathTextBox);
      this.groupBox2.Location = new System.Drawing.Point(14, 85);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(259, 83);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Saving options";
      // 
      // BrowseButton
      // 
      this.BrowseButton.Location = new System.Drawing.Point(7, 47);
      this.BrowseButton.Name = "BrowseButton";
      this.BrowseButton.Size = new System.Drawing.Size(246, 23);
      this.BrowseButton.TabIndex = 1;
      this.BrowseButton.Text = "Browse";
      this.BrowseButton.UseVisualStyleBackColor = true;
      this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
      // 
      // FilePathTextBox
      // 
      this.FilePathTextBox.BackColor = System.Drawing.Color.White;
      this.FilePathTextBox.Enabled = false;
      this.FilePathTextBox.Location = new System.Drawing.Point(7, 20);
      this.FilePathTextBox.Name = "FilePathTextBox";
      this.FilePathTextBox.Size = new System.Drawing.Size(246, 20);
      this.FilePathTextBox.TabIndex = 0;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.copyToClipboard);
      this.groupBox4.Controls.Add(this.SaveButton);
      this.groupBox4.Location = new System.Drawing.Point(14, 174);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(12, 3, 12, 12);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(259, 52);
      this.groupBox4.TabIndex = 3;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Convert";
      // 
      // copyToClipboard
      // 
      this.copyToClipboard.Location = new System.Drawing.Point(135, 19);
      this.copyToClipboard.Name = "copyToClipboard";
      this.copyToClipboard.Size = new System.Drawing.Size(118, 23);
      this.copyToClipboard.TabIndex = 1;
      this.copyToClipboard.Text = "Copy to Clipboard";
      this.copyToClipboard.UseVisualStyleBackColor = true;
      this.copyToClipboard.Click += new System.EventHandler(this.copyToClipboard_Click);
      // 
      // SaveButton
      // 
      this.SaveButton.Location = new System.Drawing.Point(6, 19);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(118, 23);
      this.SaveButton.TabIndex = 0;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // extendedFeaturesGroupBox
      // 
      this.extendedFeaturesGroupBox.AutoSize = true;
      this.extendedFeaturesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.extendedFeaturesGroupBox.Controls.Add(this.extendedFeaturesPanel);
      this.extendedFeaturesGroupBox.Location = new System.Drawing.Point(14, 232);
      this.extendedFeaturesGroupBox.Margin = new System.Windows.Forms.Padding(12, 3, 12, 12);
      this.extendedFeaturesGroupBox.MinimumSize = new System.Drawing.Size(259, 20);
      this.extendedFeaturesGroupBox.Name = "extendedFeaturesGroupBox";
      this.extendedFeaturesGroupBox.Size = new System.Drawing.Size(259, 20);
      this.extendedFeaturesGroupBox.TabIndex = 4;
      this.extendedFeaturesGroupBox.TabStop = false;
      this.extendedFeaturesGroupBox.Text = "Extended Features";
      // 
      // extendedFeaturesPanel
      // 
      this.extendedFeaturesPanel.AutoSize = true;
      this.extendedFeaturesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.extendedFeaturesPanel.Location = new System.Drawing.Point(3, 16);
      this.extendedFeaturesPanel.Name = "extendedFeaturesPanel";
      this.extendedFeaturesPanel.Size = new System.Drawing.Size(253, 1);
      this.extendedFeaturesPanel.TabIndex = 0;
      // 
      // MenuStrip
      // 
      this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem});
      this.MenuStrip.Location = new System.Drawing.Point(0, 0);
      this.MenuStrip.Name = "MenuStrip";
      this.MenuStrip.Size = new System.Drawing.Size(285, 24);
      this.MenuStrip.TabIndex = 5;
      this.MenuStrip.Text = "Help";
      // 
      // HelpMenuItem
      // 
      this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
      this.HelpMenuItem.Name = "HelpMenuItem";
      this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
      this.HelpMenuItem.Text = "Help";
      // 
      // AboutMenuItem
      // 
      this.AboutMenuItem.Name = "AboutMenuItem";
      this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
      this.AboutMenuItem.Text = "About";
      this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
      // 
      // TableConverterDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(285, 372);
      this.Controls.Add(this.extendedFeaturesGroupBox);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.MenuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.MenuStrip;
      this.MaximizeBox = false;
      this.Name = "TableConverterDialog";
      this.Text = "Convert";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableConverterDialog_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.extendedFeaturesGroupBox.ResumeLayout(false);
      this.extendedFeaturesGroupBox.PerformLayout();
      this.MenuStrip.ResumeLayout(false);
      this.MenuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox ConverterComboBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button BrowseButton;
    private System.Windows.Forms.TextBox FilePathTextBox;
    private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.GroupBox extendedFeaturesGroupBox;
    private System.Windows.Forms.Panel extendedFeaturesPanel;
    private System.Windows.Forms.Button copyToClipboard;
    private System.Windows.Forms.MenuStrip MenuStrip;
    private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
  }
}