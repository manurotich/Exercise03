using Exercise02;
using System;

namespace Exercise03
{
    class Program
    {

        static void Main(string[] args)
        {
            //Solution 1
            Console.WriteLine("Solution 1");
            Console.WriteLine("The class library describes an integer");
            Console.Write("Enter a numeric value: ");
            Class1.IntegerValue = Console.ReadLine();
            DescribeInteger();


            //Trial Solution 2
            StrongType_DescribeInteger();
        }

        private static void DescribeInteger()
        {
            Class1 solve = new Class1();
            solve.DescribeValue();
            Console.WriteLine("Description: " + Class1.DecribedValue);
        }

        private static void StrongType_DescribeInteger()
        {
            //Enter 1000000 or 2000000
            Console.WriteLine("Solution 2");
            Console.WriteLine("The class library describes an integer");
            Console.Write("Enter a integer (Either 1000000 or 2000000): ");
            Class1.Strong_Input_value = Console.ReadLine();

            if (Class1.Strong_Input_value == Class1.One_Million_Val)
            {
                Console.WriteLine(Class1.One_million);
            }

            else if (Class1.Strong_Input_value == Class1.Two_million_Val)
            {
                Console.WriteLine(Class1.Two_million);
            }

            else
            {
                Console.WriteLine("This strong typed library only checks two values i.e 1000000 and 2000000");
            }
        }
    }
}
