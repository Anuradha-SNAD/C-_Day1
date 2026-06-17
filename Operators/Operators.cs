using System;
using System.Collections.Generic;
using System.Text;

namespace Operators.Operators
{
    internal class Operators
    {

        public static void operators()
        {
            int a = 20;
            int b = 10;
            Console.WriteLine("=== Arithematic Operators ===");

            Console.WriteLine("Addition = " + (a + b));
            Console.WriteLine("Substraction = " + (a - b));
            Console.WriteLine("Multiplication = " + (a * b));
            Console.WriteLine("Division = " + (a / b));
            Console.WriteLine("Modulus =  " + (a % b));

            Console.WriteLine("=== Relational Operators ===");
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

            Console.WriteLine("=== Logical Operators ===");
            Console.WriteLine(a > b && a != b);
            Console.WriteLine(a < b || a != b);

            Console.WriteLine("=== Increment and Decrement ===");
            a++;
            Console.WriteLine(a);
            b--;
            Console.WriteLine(b);
            Console.WriteLine(--a);
            Console.WriteLine(++b);


            Console.WriteLine("=== Ternary Operators ===");
            string s = a > b ? "Yes" : "No";
            Console.WriteLine(s);


            Console.WriteLine("=== Null-Coalescing Operator (??) ===");
            string name = null;
            string res = name ?? "Hello..!!!";
            Console.WriteLine(res);

            Console.WriteLine("=== Type Operators ===");
            object value = "Hello";
            Console.WriteLine(value is string);//true
            Console.WriteLine(value is int);//false
        }
    }
}
