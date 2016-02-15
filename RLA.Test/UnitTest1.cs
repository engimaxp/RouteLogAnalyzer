using System;
using NUnit.Framework;
using RLA.Common;
using RLA.Model;
using RLA.Service;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Text.RegularExpressions;
namespace RLA.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            XDocument doc = XDocument.Load(FileHelper.GetRootDir(@"\XML\RouteConfig.xml"));
            var x = doc.Descendants();
            var y = from everything in x select everything.Value;
            Assert.IsNotNull(x);
        }
        [Test]
        public void TestMethod2()
        {
            string dir = @"\Xml\RouteConfig.xml";
            var actual = FileHelper.GetRootDir(dir);
            Assert.AreEqual(@"D:\PopoProject\RouteLogAnalyzer\Xml\RouteConfig.xml", actual);
        }
    }
}
