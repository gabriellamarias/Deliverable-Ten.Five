using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverable10._5
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Triangle> userTriangles = new List<Triangle>();
            bool userContinue = true;

            while (userContinue == true)
            {
                Console.Write("Enter the side lengths of a triangle (q to quit): ");

                var userInput = Console.ReadLine();

                if (userInput != "q")
                {
                    var sides = userInput.Split(' ');

                    int usersideLengthOne = int.Parse(sides[0]);
                    int usersideLengthTwo = int.Parse(sides[1]);
                    int usersideLengthThree = int.Parse(sides[2]);


                    Triangle t = new Triangle(usersideLengthOne, usersideLengthTwo, usersideLengthThree);

                    userTriangles.Add(t);
                }
                else if (userInput == "q")
                {

                    Console.WriteLine($"Average Area: {Area(userTriangles)}");
                    Console.WriteLine($"Average Perimeter: {Perimeter(userTriangles)}");

                    Console.Write("Do you wish to continue (y/n)? ");
                    userInput = Console.ReadLine();
                    userTriangles.Clear();

                    if (userInput == "n")
                    {
                        userContinue = false;

                        Console.WriteLine("Goodbye!");
                    }
                }
            }
        }

        public static double Perimeter(List<Triangle> userTriangles)
        {
            List<int> addedTriangles = new List<int>();
            foreach (Triangle c in userTriangles)
            {
                int x = c.sideLengthOne + c.sideLengthTwo + c.sideLengthThree;
                addedTriangles.Add(x);
            }
            return addedTriangles.Average();
            
        }
        public static double Area(List<Triangle> userTriangles)
        {
            List<int> areaTriangles = new List<int>();
            foreach (Triangle c in userTriangles)
            {
                int x = (c.sideLengthOne * c.sideLengthTwo) / 2;
                areaTriangles.Add(x);
            }
            return areaTriangles.Average();
        }
    }
}
