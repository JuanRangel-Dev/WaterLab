using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class WaterLab
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that will:
             * 
             *              -Assume that a gallon of water weighs 8.33 pounds
             *              -Prompt the user to enter a number of gallons
             *              -Display the total weight of the water in pounds
             *              
             */



            Console.Write("Please enter your amount of Gallons!: ");

            decimal dec1 = 8.33m;

            Console.WriteLine(dec1 * int.Parse(Console.ReadLine()));


        }//end Main()
    }//end class
}//end namespace
