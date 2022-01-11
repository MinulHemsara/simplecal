using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplecal
{
    internal class Program
    {
        

        static void Main(string[] args)
        {   
            double no1,no2,ans; 
            Console.WriteLine("calculator in c#");
            Console.WriteLine("----------");
            Console.Write("Type a number and then press enter ");
            no1 = Convert.ToDouble (Console.ReadLine()); 
            Console.Write("Type another number and the press enter ");
            no2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list ");
            Console.WriteLine("\ta - ADD");
            Console.WriteLine("\ts - SUB");
            Console.WriteLine("\tm - MUL");
            Console.WriteLine("\td - DIVIDE");
            Console.WriteLine("Your option");
            string opt = Console.ReadLine();
            switch(opt)
            {
                case "a":
                    ans = no1 + no2;
                    Console.WriteLine("Addition is " + ans);
                    break;
                case "s":
                    ans = no1 - no2;
                    Console.WriteLine("Subtraction is " + ans);
                    break ;
                case "m":   
                    ans = no1 * no2;
                    Console.WriteLine("Multiplication is " + ans);
                    break;
                case "d":
                    ans = no1 / no2;
                    Console.WriteLine("division is " + ans);
                    break;

            }
            Console.Write("press any key to close ");
            Console.ReadLine();
        }
    }
}
