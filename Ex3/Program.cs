using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangleWidth;
            int rectangleHeight;
            string width, height;

            Console.WriteLine("Please insert rectangle dimensions!");
            Console.WriteLine("Width:");
            width = Console.ReadLine();
            Console.WriteLine("Height:");
            height = Console.ReadLine();

            if(int.TryParse(width,out rectangleWidth) && int.TryParse(height, out rectangleHeight))
            {
                Console.WriteLine("Lenght of this rectangle: " + Math.Sqrt(Math.Pow(rectangleHeight, 2) + Math.Pow(rectangleWidth, 2)));
            }
            else
            {
                Console.WriteLine("Something is wrong with given rectangle dimensions");
            }
        }
    }
}
