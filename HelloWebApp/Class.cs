using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWebApp
{
    [TestClass]
    public class UTestClass
    {
        [TestMethod]
        public void Test()
        {
#if DEBUG
            Assert.IsTrue(false,"条件不符合");
#else
            
#endif
        }
    }
}
