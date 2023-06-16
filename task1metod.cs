using System;

namespace fuad
{
    class Program
    {
        
        private static  Car car = new Car();
        

        static void Main(string[] args)
{

            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "a class";
            car.CurrentFuel = 40;
            car.FuelFor1Km = 3 ;
            car.Millage = 50000;

            void drive()
            {
                
                int a= int.Parse(Console.ReadLine());
                if (car.CurrentFuel > a)
                {
                    car.Millage = car.Millage + a;
                    car.CurrentFuel = car.CurrentFuel - a;
                    Console.WriteLine(car.CurrentFuel);
                    Console.WriteLine(car.Millage);
                    

                }
                else
                {
                    Console.WriteLine("xeta");
                }

            }
            drive();

        }
         }
 }
