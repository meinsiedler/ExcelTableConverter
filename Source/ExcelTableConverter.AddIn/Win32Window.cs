using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelTableConverter.AddIn
{
  internal class Win32Window : IWin32Window
  {
    public Win32Window(IntPtr handle)
    {
      Handle = handle;
    }

    public IntPtr Handle { get; private set; }
  }
}
