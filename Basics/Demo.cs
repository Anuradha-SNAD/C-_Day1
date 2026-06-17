using System;
using System.Reflection;

namespace DemoProject
{
    internal class Demo
    {
      public static void demo()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Salary : ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Intial Letter: ");
            char intial = char.Parse(Console.ReadLine());

            Console.Write("Is Employee Active?");
            bool isActive = bool.Parse(Console.ReadLine());

            Console.Write("Enter Age :");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Enter Experience : ");
            short experience = short.Parse(Console.ReadLine());

            Console.Write("Enter Mobile Number : ");
            long mobile = long.Parse(Console.ReadLine());

            Console.Write("Enter Bonus Amount: ");
            decimal bonus = decimal.Parse(Console.ReadLine());


            Console.WriteLine(" ID : " + Id);
            Console.WriteLine(" Name : " +name);
            Console.WriteLine(" Salary : " + salary);
            Console.WriteLine(" Intial : " + intial);
            Console.WriteLine(" Active : " + isActive);
            Console.WriteLine(" Age : " + age);
            Console.WriteLine(" Experience : " + experience);
            Console.WriteLine(" Mobile : " + mobile);
            Console.WriteLine(" Bonus : " + bonus);
        }
    }
}
