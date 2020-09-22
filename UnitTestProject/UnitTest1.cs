using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAP_WebService;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestWebService
    {
        [TestMethod]
        public void TestFibonacci()
        {
            WebService ws = new WebService();
            Assert.IsNotNull(ws);
            Assert.AreEqual(-1, ws.Fibonacci(-1));
            Assert.AreEqual(1, ws.Fibonacci(1));
            Assert.AreEqual(1, ws.Fibonacci(2));
            Assert.AreEqual(2, ws.Fibonacci(3));
            Assert.AreEqual(3, ws.Fibonacci(4));
            Assert.AreEqual(5, ws.Fibonacci(5));
            Assert.AreEqual(8, ws.Fibonacci(6));
            Assert.AreEqual(-1, ws.Fibonacci(-101));
            Assert.AreEqual(-1, ws.Fibonacci(1000));
            ws.Dispose();
        }

        [TestMethod]
        public void TestXmlToJson()
        {
            WebService ws = new WebService();
            Assert.IsNotNull(ws);
            Assert.AreEqual("{  \"foo\": \"bar\"}", ws.XmlToJson("<foo>bar</foo>").Replace("\r\n", ""));
            Assert.AreEqual("{  \"foo\": {    \"bar\": \"76\",    \"top\": \"ABC\"  }}", ws.XmlToJson("<foo><bar>76</bar><top>ABC</top></foo>").Replace("\r\n", ""));
            Assert.AreEqual("Bad Xml format", ws.XmlToJson("<foo>hello</bar>"));
            ws.Dispose();
        }
    }
}
