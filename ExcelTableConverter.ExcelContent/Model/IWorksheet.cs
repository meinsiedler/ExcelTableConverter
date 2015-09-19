using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTableConverter.ExcelContent.Model
{
  public interface IWorksheet
  {
    string Name { get; }
    IRange Cells { get; }
  }
}
