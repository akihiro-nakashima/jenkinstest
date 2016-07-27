using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class HelloTests
    {
        Hello hello=new Hello();
        [TestMethod()]
        public void hellotestTest()
        {
            try
            {
                hello.hellotest();
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}