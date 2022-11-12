using LineComparison;

namespace LineComparision3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateLength calculateLength = new CalculateLength(5, 2, 5, 1);
            calculateLength.Calculate();
        }
    }
}