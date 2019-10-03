using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result5 = Program.IsContain5(Arr1);
            Assert.AreEqual(false, result5);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result0 = Program.IsContain5(Arr2);
            Assert.AreEqual(true, result0);
        }

        [TestMethod]
        public void TestContain5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result5 = Program.IsContain5or6(Arr1);
            Assert.AreEqual(false, result5);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result5or6 = Program.IsContain5or6(Arr2);
            Assert.AreEqual(true, result5or6);
        }

        [TestMethod]
        public void TestContain5And6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result5 = Program.IsContain5And6(Arr1);
            Assert.AreEqual(false, result5);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result5and6 = Program.IsContain5And6(Arr2);
            Assert.AreEqual(true, result5and6);
        }

        [TestMethod]
        public void TestCount5()
        {
            int[] arr = new int[] { 1, 5, 5, 2, 5, 6 };
            int result3 = Program.Count5(arr);
            Assert.AreEqual(3, result3);

            int[] arr1 = new int[] { 5, 2, 3, 4, 5, 3, 2 };
            int result2 = Program.Count5(arr1);
            Assert.AreEqual(2, result2);
        }

        [TestMethod]
        public void TestCount5or6()
        {
            int[] arr = new int[] { 1, 5, 5, 2, 5, 6 };
            int result4 = Program.Count5or6(arr);
            Assert.AreEqual(4, result4);

            int[] arr1 = new int[] { 5, 2, 3, 4, 5, 3, 2 };
            int result2 = Program.Count5or6(arr1);
            Assert.AreEqual(2, result2);
        }

        [TestMethod]
        public void SumArr()
        {
            int[] arr = new int[] { 1, 5, 5, 2, 5, 6 };
            int resultSum1 = Program.SumArr(arr);
            Assert.AreEqual(24, resultSum1);

            int[] arr1 = new int[] { 5, 2, 3, 4, 5, 3, 2 };
            int resultSum2 = Program.SumArr(arr1);
            Assert.AreEqual(24, resultSum2);
        }
    }
}
