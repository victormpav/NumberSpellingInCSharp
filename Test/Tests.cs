using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DojoTDD;

namespace Test
{
    [TestFixture]
    class Tests
    {
        private Model model;
        private DisplayMock display;

        [SetUp]
        public void SetUp()
        {
            
            display = new DisplayMock();
            model = new Model(display);
        }

        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(5, "five")]
        [TestCase(10, "ten")]
        [TestCase(15, "fifteen")]
        [TestCase(21, "twenty one")]
        [TestCase(30, "thirty")]
        [TestCase(56, "fifty six")]
        [TestCase(99, "ninety nine")]
        public void test(int number, string expected)
        {
            model.SpellOutNumber(number);

            Assert.AreEqual(expected, display.LastDisplayed);
        }


    }
}
