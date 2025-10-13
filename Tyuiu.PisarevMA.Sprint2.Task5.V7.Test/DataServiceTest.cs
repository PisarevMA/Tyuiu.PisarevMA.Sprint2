using Tyuiu.PisarevMA.Sprint2.Task5.V7.Lib;
namespace Tyuiu.PisarevMA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            int year = 1990;
            int n = 5;
            string q = ds.FindMonthName(year, n);
            Assert.AreEqual("Май", q);
        }
    }
}
