using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsMaxProblem;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(100,10,20,100)]    //TC 1.1
        [DataRow(10,100,20,100)]    //TC 1.2
        [DataRow(10,10,200,200)]    //TC 1.3
        public void TestCase1(int x,int y, int z, int expected)
        {
            int actual = Program.GetMax(x,y,z);
            Assert.AreEqual(actual, expected);
        }
    }
}
