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

            // int x=5,y=4,z=3;

            // x+=5; // x=x+5;
            // y*=5;
            // z/=3;       

            // Console.WriteLine($"X is {x},Y is {y},Z is {z}");

            // int t=2;    
            // double result=Math.Pow(t,4);

            // Console.WriteLine($"4th power of t={t} is {result}");

            // double q=5.3;

            // double rounded=Math.Round(q);
            // Console.WriteLine($"Rounded of q={q} is {rounded}");


            // **************************


            // Comparison Operators

              // password,username => database
            // '13456','sadikturan'

            // int a=5,b=5,c=10,d=4;
            // string username = "sadikturan";
            // string password = "1234567";

            // var result = (a == b); // true
            // result = (a == c); // false
            // result = (username == "sdktrn");
            // result = (password == "123456");
            // result = (a != b);
            // result = (a != c);
            // result = (a > c);
            // result = (c > a);
            // result = (a >= b);
            // result = (a <= b);
            
            // string sonuc = (a == b)?"a=b":"a!=b";
            // sonuc = (username == "sadikturan")?
            //             (password == "123456")?"username doğru ve parola doğru":"username doğru ve parola yanlış":
            //             (password == "123456")?"username yanlış ve parola doğru":"username yanlış ve parola yanlış";
           

            // Console.WriteLine(sonuc);
            // Console.WriteLine("result: "+result);


            // ***********************

            //  Logical Operators (&&,||,!)
            // int x = 6;

            // int hak = 0;
            // char devammi='e';
            // // and (&&)
            // // true && true => true
            // // false && true => false
            // // false || false => false

            // var result = (x>5) && (x<10); 
            // result = (hak>0) && (devammi=='e');

            // // or (||)
            // // true || true => true
            // // false || true => true
            // // false || false => false

            // result = (x > 0) || (x % 2 == 0);

            // // not (!)
            // // true => false
            // // false => true

            // result = !(x>0);

            // // x, 5-10 arasında olan bir çift sayı mıdır?
            // result = ((x>5) && (x<10)) && (x%2==0); // (true && true) && true

            // Console.Write(result);


            // ******************************

            // Operators Application

            int num;
            num=Convert.ToInt32(Console.ReadLine());
            string result=(num%2==0&&num>0)?"Positive even number":"Not positive even number";
            Console.WriteLine(result);







        }
    }
}
