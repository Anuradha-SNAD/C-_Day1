using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    public class LoopingStmt
    {
        public static void run()
        {
            Console.WriteLine("do while loop");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
        public static void run2()
        {
            Console.WriteLine("While Loop");
            int a = 5;
            while(a <= 20)
            {
                Console.WriteLine(a+" ");
                a++;
            }
        }
   
        public static void run3()
        {
            Console.WriteLine("for Loop");
            int a = 50;
            for(int i = a; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
        }

    }
}
