using Tyuiu.PisarevMA.Sprint2.Task7.V6.Lib;
namespace Tyuiu.PisarevMA.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInSharedArea()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 1.0;
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), true);
        }
    }
}
