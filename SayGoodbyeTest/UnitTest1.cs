using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SayGoodbyeTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Goodbye World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                SayGoodbye.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
