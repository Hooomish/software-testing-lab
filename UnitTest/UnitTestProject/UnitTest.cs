using System;
using CheckTriangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTriangle
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestTriangle1()
        {
            bool isExistTriangle = Triangle.CheckTriangle(5, 7, 2);
            Assert.AreEqual(true, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle2()
        {
            bool isExistTriangle = Triangle.CheckTriangle(0, 2, 2);
            Assert.AreEqual(false, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle3()
        {
            bool isExistTriangle = Triangle.CheckTriangle('s', 8, 1);
            Assert.AreEqual(true, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle4()
        {
            bool isExistTriangle = Triangle.CheckTriangle(0, 0, 0);
            Assert.AreEqual(false, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle5()
        {
            bool isExistTriangle = Triangle.CheckTriangle(double.MaxValue, 7, 2);
            Assert.AreEqual(true, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle6()
        {
            bool isExistTriangle = Triangle.CheckTriangle(5, int.MaxValue, 2);
            Assert.AreEqual(true, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle7()
        {
            bool isExistTriangle = Triangle.CheckTriangle(-5, 7, -2);
            Assert.AreEqual(false, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle8()
        {
            bool isExistTriangle = Triangle.CheckTriangle(1, 1, 1);
            Assert.AreEqual(true, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle9()
        {
            bool isExistTriangle = Triangle.CheckTriangle(1, 0, 1);
            Assert.AreEqual(true, isExistTriangle);
        }

        [TestMethod]
        public void TestTriangle10()
        {
            bool isExistTriangle = Triangle.CheckTriangle(200, 500, 300);
            Assert.AreEqual(true, isExistTriangle);
        }
    }
}
