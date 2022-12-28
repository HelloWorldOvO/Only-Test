using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.Tests
{
    [TestClass()]
    public class MupTests
    {
        [TestMethod()]
        public void equal()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void multiplyTest()
        {
            // 試運算
            string[] args = { "8", "7" };
            int result = AutoTest.Mup.multiply(args);

            // 結果是否正確
            Assert.AreEqual(56, result);
        }
    }
}