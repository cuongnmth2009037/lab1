using System;
using System.Runtime.InteropServices;
using System.Text;
using Lab1.Exercise1;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Exercise 1:
            Information information = new Information();
            Console.WriteLine("Please enter your name:  ");
            information.Name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            information.Address = Console.ReadLine();
            Console.WriteLine("Please enter your phone: ");
            information.Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The information you just entered is: ");
            Console.WriteLine($"Name : {information.Name}. Address: {information.Address}. Phone: {information.Phone}");


            // Exercise 2:
            Console.WriteLine("Please enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >=b && a >= c)
            {
                Console.WriteLine($"Max: {a}");
            }
            if (b >=a && b >= c)
            {
                Console.WriteLine($"Max: {b}");
            }
            if (c >= a && c >= b)
            {
                Console.WriteLine($"Max: {c}");
            }


            //Exercise 3:
            while (true)
            {
                Console.WriteLine("Please enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine(" Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
            
            //Exercise 4:
            Console.WriteLine("Please enter your number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
            
            
            //Exercise 5:
            Console.WriteLine("Write a program to print the factorials of the integers from 1 to 20: ");
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <=20; j++)
                {
                    Console.WriteLine($"{i*j}");
                }
                Console.WriteLine();
            }








        }
    }
}