using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MorseCode.Tests
{
    [TestClass]
    public class SolidSignalTest
    {
        [TestMethod]
        public void shouldReturn()
        {
            List<String> expected = new List<string>();
            expected.Add("E");


            MorseCode decoder = new MorseCode();
            Assert.AreEqual(expected, decoder.decode("."));
        }
    }
}
