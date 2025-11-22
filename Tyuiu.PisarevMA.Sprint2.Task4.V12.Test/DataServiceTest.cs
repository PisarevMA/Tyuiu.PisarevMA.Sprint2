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
            double y = 4, x = 9;
            Assert.AreEqual(8.822, ds.Calculate(x, y));
        }

        
    }
}
