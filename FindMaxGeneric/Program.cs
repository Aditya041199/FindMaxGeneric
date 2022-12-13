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
            int max = FindMaximum.FindIntMax(100, 500, 1000);
            Console.WriteLine(max);
            float floatmax = FindMaximum.FindfloatMax(256.23f, 388.23f, 422.25f);
            Console.WriteLine(floatmax);
        }
    }
}