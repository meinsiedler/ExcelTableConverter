using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExcelTableConverter.Utilities.Tests
{
  [TestFixture]
  class ArgumentUtilityTests
  {
    [Test]
    public void EnsureNotNull_WithNull_ThrowsException()
    {
      Assert.Throws<ArgumentNullException>(() => ArgumentUtility.EnsureNotNull(null, "param"));
    }

    [Test]
    public void EnsureNotNull_WithValue_DoesNotThrowException()
    {
      ArgumentUtility.EnsureNotNull(new object(), "param");
    }

    [Test]
    public void EnsureCondition_WithFailingCondition_ThrowsException()
    {
      Assert.Throws<ArgumentException>(() => ArgumentUtility.EnsureCondition(5, x => x % 2 == 0, "param"));
    }

    [Test]
    public void EnsureCondition_WithPassingCondition_DoesNotThrowException()
    {
      ArgumentUtility.EnsureCondition(4, x => x % 2 == 0, "param");
    }
  }
}
