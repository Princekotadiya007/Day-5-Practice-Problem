using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Prectice_Problem
{
    internal class MinmumNumber
    {
        public void MinNumber()
        {
            Console.WriteLine("Enter three integers:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = num1; // assume num1 is the minimum

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine("Minimum value is: " + min);
        }
        public void Float()
        {
            Console.WriteLine("Enter three float:");

            int num1 = (int)float.Parse(Console.ReadLine());
            int num2 = (int)float.Parse(Console.ReadLine());
            int num3 = (int)float.Parse(Console.ReadLine());

            int min = num1; // assume num1 is the minimum

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine("Minimum value is: " + min);
        }
        public void String()
        {
            Console.WriteLine("Enter three strings:");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            string min = str1; // assume str1 is the minimum

            if (str2.CompareTo(min) < 0)
            {
                min = str2;
            }

            if (str3.CompareTo(min) < 0)
            {
                min = str3;
            }

            Console.WriteLine("Minimum string is: " + min);
        }
    }
}
