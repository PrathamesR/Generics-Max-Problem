using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsMaxProblem;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(new int[] {100, 10, 20}, 100)]    //TC 1.1
        [DataRow(new int[] { 10, 100, 20}, 100)]    //TC 1.2
        [DataRow(new int[] { 10, 10, 200 }, 200)]    //TC 1.3
        public void TestCase1(int[] arr, int expected)
        {
            int actual = new GetMaxClass<int>(arr).GetMax();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(new float[] { 10.0f, 1.1f, 2.3f }, 10.0f)]    //TC 2.1
        [DataRow(new float[] { 1.6f, 10.1f, 2.03f }, 10.1f)]    //TC 2.2
        [DataRow(new float[] { 1.4f, 10.3f, 20.8f }, 20.8f)]    //TC 2.3
        public void TestCase2(float[] arr, float expected)
        {
            float actual = new GetMaxClass<float>(arr).GetMax();
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        [DataRow(new string[] { "1", "2", "3" }, "3")]    //TC 3
        public void TestCase3(string[] arr, string expected)
        {
            string actual = new GetMaxClass<string>(arr).GetMax();
            Assert.AreEqual(actual, expected);
        }
    }
}
