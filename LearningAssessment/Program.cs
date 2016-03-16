using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAssessment
{
    class Program
    {
        static void Main(string[] args)
        {


            //1- Create a program that asks the user to enter an integer.
            //      If the integer is less than 10, print the message "This number is too small". 
            //      If the integer is greater than or equal to 10, print "This number is big enough". 

            Console.WriteLine("Program 1 :: ");
            Console.WriteLine("enter your number");
            int x = int.Parse(Console.ReadLine());

            if (x < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }

            //2- Create a program that creates an array of five hard-coded floating-point values,
            //      then prints out just the second value.
            Console.WriteLine("Program 2 :: ");

            float[] hardCoded = { 3.15f, 3.63f, 3.1f, 9.7f, 4.3f };
            Console.WriteLine(hardCoded[1]);

            // 3- Modify the above program so that it uses a foreach loop to display all the values in the array,
            //   all on  one line.
            Console.WriteLine("Program 3 :: ");

            foreach (float number in hardCoded)
                Console.Write(number + "   ");
            Console.WriteLine();
            // 4- Write a program that asks the user to enter an integer.
            //     If the user enters '1', print "Only one?".
            //     If the user enters '100', print "100? That's a lot!".
            //     If the user enters something other than these two numbers, print "Input not recognized.".
            //     The program should use a switch statement.
            Console.WriteLine("Program 4 :: ");

            Console.WriteLine("enter an integer");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Only one?");
                    break;

                case 100:
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:
                    Console.WriteLine("Input not recognized.");
                    break;
            }
            }
    }
}
