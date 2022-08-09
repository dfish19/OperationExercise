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
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine();



            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine();


            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);



            AreaOfCircle(radius);
            Console.WriteLine(AreaOfCircle(radius));
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static int Modulus(int a, int b)
        {
            return a % b;
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
       
        }
    }   


