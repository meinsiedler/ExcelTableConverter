using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTableConverter.ExcelContent.Model
{
  public interface IFont
  {
    bool Bold { get; set; }
    bool Italic { get; set; }

    int OleColor { get; set; }
  }
}
