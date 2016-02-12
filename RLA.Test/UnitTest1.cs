using System;
using NUnit.Framework;

namespace RLA.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string haha = "haha";
            Assert.AreEqual(haha, "haha");
        }
    }
}
