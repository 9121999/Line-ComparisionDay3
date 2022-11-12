using System;
namespace LineComprasionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLine, secondLine;

            CalculateLength line = new CalculateLength(3, 4, -2, 3);
            firstLine = line.Calculate();
            CalculateLength line1 = new CalculateLength(1, 2, 3, 4);
            secondLine = line1.Calculate();

            if (firstLine.Equals(secondLine))
            {
                Console.WriteLine("Calculate lines are Equal");
            }
            else
            {
                Console.WriteLine(" Calculate  lines are Not equal");
            }
        }
    }
}