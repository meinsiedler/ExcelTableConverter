using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.AddIn
{
  /// <summary>
  /// <c>ReflectionConverterLoader</c> finds all concrete classes derived from <c>BaseTableConverter</c>.
  /// Note that the assembly containing the class must be referenced by this assembly.
  /// </summary>
  public class ReflectionConverterLoader : IConverterLoader
  {
    public IEnumerable<BaseTableConverter> GetConverters()
    {
      return from type in GetTypesOf<BaseTableConverter>()
        let instance = (BaseTableConverter) Activator.CreateInstance(type)
        orderby instance.ToString()
        select instance;
    }
    
    private static IEnumerable<Type> GetTypesOf<T>()
    {
      return (from assemblyName in typeof (ReflectionConverterLoader).Assembly.GetReferencedAssemblies()
        let assembly = Assembly.Load(assemblyName)
        from assemblyType in assembly.GetTypes()
        where assemblyType.IsClass && !assemblyType.IsAbstract && assemblyType.IsSubclassOf(typeof (T))
        select assemblyType);
    } 
  }
}
