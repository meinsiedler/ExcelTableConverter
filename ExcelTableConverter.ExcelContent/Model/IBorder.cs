using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTableConverter.ExcelContent.Model
{
  public interface IBorder
  {
    BorderInformation.BorderStyleEnum LineStyle { get; }
    BorderInformation.ThicknessEnum Weight { get; }
  }
}
