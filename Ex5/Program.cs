using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, email, city, postCode, phoneNumber;
            int age, height;
            float weight;

            Console.WriteLine("Insert your data below:");

            Console.WriteLine("Your first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Your last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Your email address:");
            email = Console.ReadLine();

            Console.WriteLine("Your city:");
            city = Console.ReadLine();

            Console.WriteLine("Your post code:");
            postCode = Console.ReadLine();

            Console.WriteLine("Your phone number:");
            phoneNumber = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Your age:");
                if(int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Inserted data was wrong");
                }
            }

            while (true)
            {
                Console.WriteLine("Your height:");
                if (int.TryParse(Console.ReadLine(), out height))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Inserted data was wrong");
                }
            }

            while (true)
            {
                Console.WriteLine("Your weight:");
                if (float.TryParse(Console.ReadLine(), out weight))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Inserted data was wrong");
                }
            }
        }
    }
}
