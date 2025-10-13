using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PisarevMA.Sprint2.Task4.V12.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Sqrt(x) > y * 2 ? Math.Pow(7 + (2 / Math.Pow(y, 2)), x) : (3 * Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 10) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 12);

            return Math.Round(z, 3);

        }
    }
}
