using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelTableConverter.AddIn
{
  partial class AboutBox : Form
  {
    public AboutBox()
    {
      InitializeComponent();
      Text = String.Format("About {0}", AssemblyProduct);
      labelProductName.Text = AssemblyProduct;
      labelVersion.Text = String.Format("Version {0}", RemoveBuildNumberFromVersion(AssemblyVersion));
      labelCopyright.Text = AssemblyCopyright;
      textBoxDescription.Text = string.Format("{0}{1}{1}{2}",
        AssemblyDescription, Environment.NewLine,
        "For more information and updates check out the above-noted GitHub URL.");
      licenseLinkLabel.Links.Clear();
      licenseLinkLabel.Links.Add(19, 11, "https://opensource.org/licenses/MIT");

    }

    #region Assembly Attribute Accessors

    public string AssemblyVersion
    {
      get
      {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }

    public string AssemblyDescription
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
      }
    }

    public string AssemblyProduct
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyProductAttribute)attributes[0]).Product;
      }
    }

    public string AssemblyCopyright
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    #endregion

    private string RemoveBuildNumberFromVersion(string version)
    {
      var lastDotIndex = version.LastIndexOf('.');
      if (lastDotIndex == -1)
        return version;

      return version.Substring(0, lastDotIndex);
    }

    private void githubUrlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(githubUrlLinkLabel.Text);
    }

    private void licenseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(licenseLinkLabel.Links[0].LinkData.ToString());
    }

    private void releasesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://github.com/meinsiedler/ExcelTableConverter/releases");
    }

    private void changelogLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://github.com/meinsiedler/ExcelTableConverter/blob/master/CHANGELOG.md");
    }
  }
}
