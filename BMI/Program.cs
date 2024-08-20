using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER YOUR WEIGHT IN KILOGRAMS: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("YOUR WEIGHT IS "+weight+"kg");
            Console.Write("ENTER YOUR HEIGHT IN METERS: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("YOUR HEIGHT IS "+height + "M");

            double result = weight / (height*height);

            Console.WriteLine("YOUR BMI IS " + result);

            if (result >= 40)
            {
                Console.WriteLine("YOU ARE A FAT FAK");
            }
            else if (result >= 25)
            {
                Console.WriteLine("YOU ARE OVER WEIGHT");
            }
            else if (result >= 18.5)
            {
                Console.WriteLine("YOU ARE NORMAL");
            }
            else
            {
                Console.WriteLine("YOU ARE UNDEREIGHT");
            }











            Console.ReadLine();
        }
    }
}
