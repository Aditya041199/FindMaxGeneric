using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxGeneric
{
    public class Program
    {
            static void Main(string[] args)
            {
                int max = FindMaximum.FindIntMax(1000, 100, 500);
                Console.WriteLine(max);
            }
    }
}