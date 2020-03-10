using System;

namespace Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbEmployees = StatisticsCalculator.NombreEmployeeRDV();
            Console.WriteLine(nbEmployees);
        }
    }
}
