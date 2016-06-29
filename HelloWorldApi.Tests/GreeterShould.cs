using System;
using HelloWorldApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class GreeterShould
    {
        [TestMethod]
        public void SayHello()
        {
            Assert.AreEqual("Hello", Greeter.Greet());
        }

        [TestMethod]
        public void SayHelloToJoe()
        {
            Assert.AreEqual("Hello Joe", Greeter.Greet("Joe"));
        }

        [TestMethod]
        public void SayHelloToNull()
        {
            Assert.AreEqual("Hello", Greeter.Greet(null));
        }
    }
}
