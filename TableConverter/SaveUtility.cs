using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace METools.TableConverter
{
  public class SaveUtility
  {
    private readonly string _fullPath, _content;

    public SaveUtility(string fileName, string content)
    {
      if(!ParametersValid(new List<string>(){ fileName.Trim() }))
      {
        throw new ArgumentException("not all parameters are valid");
      }
      _fullPath = fileName.Trim();
      _content = content.Trim();
    }

    /// <summary>
    /// saves the file with its content
    /// </summary>
    /// <returns>returns true if the saving of the file worked</returns>
    public bool SaveFile()
    {
      
      using (StreamWriter streamWriter = new StreamWriter(_fullPath))
      {
        try
        {
          streamWriter.Write(_content);
        }
        catch (UnauthorizedAccessException)
        {
          return false;
        }
      }
      return true;
    }

    /// <summary>
    /// check if all values are not null or empty
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    private static bool ParametersValid(IEnumerable<string> values)
    {
      return values.All(value => !string.IsNullOrEmpty(value));
    }
  }
}
