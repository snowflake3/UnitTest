using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTestLibrary1
{
    [TestClass]
    public class addtwonumbers
    {
        [TestMethod]
        public void addIntegers()
        {
            Assert.AreEqual(10, 5 + 5);
        }
    }
}
