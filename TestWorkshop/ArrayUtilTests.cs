using Workshop;

namespace TestWorkshop
{
    [TestClass]
    public class ArrayUtilTests
    {
        [TestMethod]
        public void TestSecondMax1()
        {
            int[] arr = new int[] { 4, 5, 5, 3};

            int actual = ArrayUtil.SecondMax(arr);
            Assert.AreEqual(42, actual);
        }
    }
}