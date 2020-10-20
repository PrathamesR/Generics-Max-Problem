using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsMaxProblem;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(100, 10, 20, 100)]    //TC 1.1
        [DataRow(10, 100, 20, 100)]    //TC 1.2
        [DataRow(10, 10, 200, 200)]    //TC 1.3
        public void TestCase1(int x, int y, int z, int expected)
        {
            int actual = Program.GetMax(x, y, z);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(10.0f, 1.1f, 2.3f, 10.0f)]    //TC 2.1
        [DataRow(1.6f, 10.1f, 2.03f, 10.1f)]    //TC 2.2
        [DataRow(1.4f, 10.3f, 20.8f, 20.8f)]    //TC 2.3
        public void TestCase2(float x, float y, float z, float expected)
        {
            float actual = Program.GetMax(x, y, z);
            Assert.AreEqual(actual, expected);
        }
    }
}
