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
            throw new Exception("no dubeg"); 
#else
            
#endif
        }
    }
}
