using modifiedCalculator.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifiedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Class1 c = new Class1();
            string menu;


            menu = Menu();
            if (menu == "1")
            {
                Console.WriteLine(c.Addition());
            }
            else if (menu == "2")
            {
                Console.WriteLine(c.Subtraction());
            }
            else if (menu == "3")
            {
                Console.WriteLine(c.Multiplication());
            }
            else if (menu == "4")
            {
                Console.WriteLine(c.Division());
            }
          
            else if(menu == "5")
            {
                Console.WriteLine(c.Sqrt());
            }
            else if(menu == "6")
            {
                Console.WriteLine(c.Expo());
            }
            else if (menu == "7")
            {
                Console.WriteLine(c.Log());
            }
            else if (menu == "8")
            {
                Console.WriteLine(c.Sin());
            }
            else if (menu == "9")
            {
                Console.WriteLine(c.Cos());
            }
            else if (menu == "10")
            {
                Console.WriteLine(c.Tan());
            }
        }
        static string Menu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("1.Add.");
            Console.WriteLine("2.Subtract.");
            Console.WriteLine("3.Multiply.");
            Console.WriteLine("4.Divide.");
            Console.WriteLine("5.Sqrt of a number.");
            Console.WriteLine("6.Exponent of a number.");
            Console.WriteLine("7.log of a number. ");
            Console.WriteLine("8.Sin of a number. ");
            Console.WriteLine("9.Cos of a number. ");
            Console.WriteLine("10.Tan of a number. ");
            Console.Write("Enter your choice.");
            option = Console.ReadLine();

            return option;
        }

     
    }
    
}
