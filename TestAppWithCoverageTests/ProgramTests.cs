using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppWithCoverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppWithCoverage.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void PrintTest()
        {
            new Program().PrintNumber();
        }

        [TestMethod()]
        public void PrintNumberTest()
        {
            Assert.AreEqual(3, new Program().GetNumber());
        }
    }
}