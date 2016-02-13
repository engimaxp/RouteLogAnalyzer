using System;
using NUnit.Framework;
using RLA.Common;
using RLA.Model;
using RLA.Service;
using System.IO;
using System.Xml;
namespace RLA.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string dir = System.AppDomain.CurrentDomain.BaseDirectory;
            var x = XMLHelper.GetXmlNodeListByXpath("RouteConfig.xml", "");
            Assert.IsNotNull(x);
        }
    }
}
