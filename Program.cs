using System;

namespace _2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArithmeticOperators
          
            // int a=10;
            // int b=8;
            // float result;

            // result=(float)a/(float)b;

            // Console.WriteLine($"Result is {result}");

            // float mod=a%b;

            // Console.WriteLine($"Mod is {mod}");

            // int c=14;
            // c=--c;
            // Console.WriteLine($"Number c is {c}");
            // c=++c;
            // Console.WriteLine($"Number c is {c}");

            // *************************************

            // Assign Operators

            int x=5,y=4,z=3;

            x+=5; // x=x+5;
            y*=5;
            z/=3;       

            Console.WriteLine($"X is {x},Y is {y},Z is {z}");

            int t=2;    
            double result=Math.Pow(t,4);

            Console.WriteLine($"4th power of t={t} is {result}");

            double q=5.3;

            double rounded=Math.Round(q);
            Console.WriteLine($"Rounded of q={q} is {rounded}");

        }
    }
}
