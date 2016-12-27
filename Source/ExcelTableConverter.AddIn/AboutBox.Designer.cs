namespace ExcelTableConverter.AddIn
{
  partial class AboutBox
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.licenseLinkLabel = new System.Windows.Forms.LinkLabel();
      this.labelProductName = new System.Windows.Forms.Label();
      this.labelVersion = new System.Windows.Forms.Label();
      this.labelCopyright = new System.Windows.Forms.Label();
      this.textBoxDescription = new System.Windows.Forms.TextBox();
      this.okButton = new System.Windows.Forms.Button();
      this.githubUrlLinkLabel = new System.Windows.Forms.LinkLabel();
      this.releasesLinkLabel = new System.Windows.Forms.LinkLabel();
      this.changelogLinkLabel = new System.Windows.Forms.LinkLabel();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
      this.tableLayoutPanel.Controls.Add(this.licenseLinkLabel, 0, 3);
      this.tableLayoutPanel.Controls.Add(this.labelProductName, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 0, 6);
      this.tableLayoutPanel.Controls.Add(this.okButton, 0, 6);
      this.tableLayoutPanel.Controls.Add(this.githubUrlLinkLabel, 0, 4);
      this.tableLayoutPanel.Controls.Add(this.releasesLinkLabel, 0, 5);
      this.tableLayoutPanel.Controls.Add(this.changelogLinkLabel, 1, 5);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 8;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.009009F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.009009F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.009009F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.009009F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.009009F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.90991F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.04504F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.Size = new System.Drawing.Size(280, 259);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // licenseLinkLabel
      // 
      this.licenseLinkLabel.AutoSize = true;
      this.tableLayoutPanel.SetColumnSpan(this.licenseLinkLabel, 2);
      this.licenseLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.licenseLinkLabel.Location = new System.Drawing.Point(6, 60);
      this.licenseLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.licenseLinkLabel.MaximumSize = new System.Drawing.Size(0, 17);
      this.licenseLinkLabel.Name = "licenseLinkLabel";
      this.licenseLinkLabel.Size = new System.Drawing.Size(271, 17);
      this.licenseLinkLabel.TabIndex = 26;
      this.licenseLinkLabel.TabStop = true;
      this.licenseLinkLabel.Text = "Released under the MIT License.";
      this.licenseLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.licenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLinkLabel_LinkClicked);
      // 
      // labelProductName
      // 
      this.tableLayoutPanel.SetColumnSpan(this.labelProductName, 2);
      this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelProductName.Location = new System.Drawing.Point(6, 0);
      this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
      this.labelProductName.Name = "labelProductName";
      this.labelProductName.Size = new System.Drawing.Size(271, 17);
      this.labelProductName.TabIndex = 19;
      this.labelProductName.Text = "Product Name";
      this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelVersion
      // 
      this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 2);
      this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelVersion.Location = new System.Drawing.Point(6, 20);
      this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(271, 17);
      this.labelVersion.TabIndex = 0;
      this.labelVersion.Text = "Version";
      this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelCopyright
      // 
      this.tableLayoutPanel.SetColumnSpan(this.labelCopyright, 2);
      this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelCopyright.Location = new System.Drawing.Point(6, 40);
      this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
      this.labelCopyright.Name = "labelCopyright";
      this.labelCopyright.Size = new System.Drawing.Size(271, 17);
      this.labelCopyright.TabIndex = 21;
      this.labelCopyright.Text = "Copyright";
      this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textBoxDescription
      // 
      this.tableLayoutPanel.SetColumnSpan(this.textBoxDescription, 2);
      this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxDescription.Location = new System.Drawing.Point(6, 125);
      this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
      this.textBoxDescription.Multiline = true;
      this.textBoxDescription.Name = "textBoxDescription";
      this.textBoxDescription.ReadOnly = true;
      this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxDescription.Size = new System.Drawing.Size(271, 97);
      this.textBoxDescription.TabIndex = 23;
      this.textBoxDescription.TabStop = false;
      this.textBoxDescription.Text = "Description";
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel.SetColumnSpan(this.okButton, 2);
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.okButton.Location = new System.Drawing.Point(202, 233);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 24;
      this.okButton.Text = "&OK";
      // 
      // githubUrlLinkLabel
      // 
      this.githubUrlLinkLabel.AutoSize = true;
      this.tableLayoutPanel.SetColumnSpan(this.githubUrlLinkLabel, 2);
      this.githubUrlLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.githubUrlLinkLabel.Location = new System.Drawing.Point(6, 80);
      this.githubUrlLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.githubUrlLinkLabel.MaximumSize = new System.Drawing.Size(0, 17);
      this.githubUrlLinkLabel.Name = "githubUrlLinkLabel";
      this.githubUrlLinkLabel.Size = new System.Drawing.Size(271, 17);
      this.githubUrlLinkLabel.TabIndex = 25;
      this.githubUrlLinkLabel.TabStop = true;
      this.githubUrlLinkLabel.Text = "https://github.com/meinsiedler/ExcelTableConverter";
      this.githubUrlLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.githubUrlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubUrlLinkLabel_LinkClicked);
      // 
      // releasesLinkLabel
      // 
      this.releasesLinkLabel.AutoSize = true;
      this.releasesLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.releasesLinkLabel.Location = new System.Drawing.Point(6, 100);
      this.releasesLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.releasesLinkLabel.MaximumSize = new System.Drawing.Size(0, 17);
      this.releasesLinkLabel.Name = "releasesLinkLabel";
      this.releasesLinkLabel.Size = new System.Drawing.Size(52, 17);
      this.releasesLinkLabel.TabIndex = 27;
      this.releasesLinkLabel.TabStop = true;
      this.releasesLinkLabel.Text = "Releases";
      this.releasesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.releasesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.releasesLinkLabel_LinkClicked);
      // 
      // changelogLinkLabel
      // 
      this.changelogLinkLabel.AutoSize = true;
      this.changelogLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.changelogLinkLabel.Location = new System.Drawing.Point(64, 100);
      this.changelogLinkLabel.MaximumSize = new System.Drawing.Size(0, 17);
      this.changelogLinkLabel.Name = "changelogLinkLabel";
      this.changelogLinkLabel.Size = new System.Drawing.Size(213, 17);
      this.changelogLinkLabel.TabIndex = 28;
      this.changelogLinkLabel.TabStop = true;
      this.changelogLinkLabel.Text = "Changelog";
      this.changelogLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.changelogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changelogLinkLabel_LinkClicked);
      // 
      // AboutBox
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(298, 277);
      this.Controls.Add(this.tableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutBox";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "AboutBox";
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.LinkLabel githubUrlLinkLabel;
    private System.Windows.Forms.LinkLabel licenseLinkLabel;
    private System.Windows.Forms.LinkLabel releasesLinkLabel;
    private System.Windows.Forms.LinkLabel changelogLinkLabel;
  }
}
