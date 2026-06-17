using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.ConditionalStatements
{
    internal class ConditionalStmt
    {
        public static void run()
        {
            Console.WriteLine("Enter the age : ");
            int age = int.Parse(Console.ReadLine());
            if(age >=18)
            {
                Console.WriteLine("You are Eligible for vote");
            }
            else
            {
                Console.WriteLine("You are not Eligible for vote");
            }
        }
        public static void run2()
        {
            Console.WriteLine("Enter the Marks : ");
            int marks = int.Parse(Console.ReadLine());
            if(marks >= 90 && marks<=100)
            {
                Console.WriteLine("Grade A+");
            }else if(marks >= 80 && marks <= 100)
            {
                Console.WriteLine("Grade A");
            } else if(marks >= 70 && marks <= 100)
            {
                Console.WriteLine("Grade B+");
            }else if(marks >= 60 && marks <= 100)
            {
                Console.WriteLine("Grade B");
            }else if(marks >= 35 && marks <= 100)
            {
                Console.WriteLine("Grade C");
            }else if(marks < 35)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Marks Under 100 only");
            }
        }
        public static void start()
        {
            Console.WriteLine("Enter the number to get the Day");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input..! Enter 1-7 ");
                        break;
                    }
            }
        }
    }
}
