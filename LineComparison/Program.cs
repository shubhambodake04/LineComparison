using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance obj = new Distance(1, 2, 1, 2);
            double LineOne = obj.Compair();
            Console.WriteLine(LineOne);

            Distance obj1 = new Distance(1, 2, 1, 2);
            double LineTwo = obj1.Compair();
            Console.WriteLine(LineTwo);

            Distance.Equal(LineOne, LineTwo);

        }
    }
}
