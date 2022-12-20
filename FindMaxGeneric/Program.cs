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
            int max = FindMaximum.FindMaximumNumber<int>(100, 500, 1000);
            Console.WriteLine(max);
            float floatmax = FindMaximum.FindMaximumNumber<float>(256.23f, 388.23f, 422.25f);
            Console.WriteLine(floatmax);
            string stringMax = FindMaximum.FindMaximumNumber<string>("Apple", "Peach", "Banana");
            Console.WriteLine(stringMax);
        }
    }
}