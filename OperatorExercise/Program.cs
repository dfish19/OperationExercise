using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
        }
        
           
    }
}
