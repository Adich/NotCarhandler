using CarHandler;
using System;
using System.Collections.Generic;

namespace NotCarHandler
{
    class Program
    {
        static List<Car> cars = new List<Car>();

        static void Main(string[] args)
        {


            Car car = new Car("Ford", "Mustang", 1967, "Red");
            cars.Add(car);

            while (true)
            {


                Console.WriteLine("Hej og velkommen til biladministrationen 1997\nDu har to valgmuligheder:\n1. Opret en bil\n2. Se informationer om alle biler.");
                string brugerInput = Console.ReadLine();

                if (brugerInput == "1")
                {
                    cars.Add(CreateCar());
                }
                else if (brugerInput == "2")
                {
                    PrintAllCars();
                }
                else
                {
                    Console.WriteLine("Det er ikke et muligt valg, din tumpe");
                }
                Console.WriteLine();
            }
        }

        public static void PrintAllCars()
        {
            foreach(Car c in cars)
            {
                Console.WriteLine(c.GetInfo());
            }
        }


        public static Car CreateCar()
        {

            Console.WriteLine("Indtast bilens mærke");
            string make = Console.ReadLine();
            Console.WriteLine("Indtast bilens model");
            string model = Console.ReadLine();
            Console.WriteLine("Indtast produktionsår");
            int productionYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast farve på bilen");
            string color = Console.ReadLine();
            Car result = new Car(make,model,productionYear,color);

            return result;
        }
    }
}
