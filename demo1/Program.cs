using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BloomFilter<string> bf = new BloomFilter<string>(20, 3);

            bf.Add("testing");
            bf.Add("nottesting");
            bf.Add("testingagain");

            Console.WriteLine(bf.Contains("badstring")); // False
            Console.WriteLine(bf.Contains("testing")); // True

            List<string> testItems = new List<string>() { "badstring", "testing", "test" };

            Console.WriteLine(bf.ContainsAll(testItems)); // False
            Console.WriteLine(bf.ContainsAny(testItems)); // True

            // False Positive Probability: 0.040894188143892
            Console.WriteLine("False Positive Probability: " + bf.FalsePositiveProbability());

            Console.ReadKey();
        }
    }
}
