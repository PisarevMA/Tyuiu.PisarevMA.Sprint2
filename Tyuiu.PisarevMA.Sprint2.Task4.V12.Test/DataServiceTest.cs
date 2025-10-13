using Tyuiu.PisarevMA.Sprint2.Task4.V12.Lib;
namespace Tyuiu.PisarevMA.Sprint2.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.901;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0.5;
            double res = ds.Calculate(x, y);
            double wait = 225;
            Assert.AreEqual(wait, res);
        }
    }
}
