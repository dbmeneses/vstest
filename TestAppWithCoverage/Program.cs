using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppWithCoverage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().PrintNumber();
        }

        public int GetNumber()
        {
            return 3;
        }

        public void PrintNumber()
        {
            Console.WriteLine("Number: " + GetNumber());

        }
    }
}
