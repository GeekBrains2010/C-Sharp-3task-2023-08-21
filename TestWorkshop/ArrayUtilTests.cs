using Workshop;

namespace TestWorkshop
{
    [TestClass]
    public class ArrayUtilTests
    {
        [TestMethod]
        public void TestSecondMax_BeforeMax()
        {
            int[] arr = new int[] {1, 4, 5, 5, 3};

            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestSecondMax_AfterMax()
        {
            int[] arr = new int[] { 1, 2, 7, 6, 3 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void TestSecondMax_FirstPosition()
        {
            int[] arr = new int[] { 5, 2, 7, 4, 3 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestSecondMax_LastPosition()
        {
            int[] arr = new int[] { 5, 2, 10, 4, 3, 9 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void TestSecondMax_FirstTwoMax()
        {
            int[] arr = new int[] { 9, 9, 8, 5, 2 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestSecondMax_LastMax()
        {
            int[] arr = new int[] { 9, 9, 8, 5, 2, 10 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void TestSecondMax_BetweenMax()
        {
            int[] arr = new int[] { 1, 9, 7, 9, 3 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void TestSecondMax_NegativeNumbers()
        {
            int[] arr = new int[] { -1, -3, -2, -1 };
            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(-2, actual);
        }
    }
}