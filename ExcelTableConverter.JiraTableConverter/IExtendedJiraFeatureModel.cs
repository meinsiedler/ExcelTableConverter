using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.JiraTableConverter
{
  public interface IExtendedJiraFeatureModel : IExtendedFeaturesModel
  {
    bool FirstRowIsHeader { get; }
  }
}
