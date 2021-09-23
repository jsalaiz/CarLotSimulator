using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.NumberOfCars++;
            Console.WriteLine($"The Number of cars in the carlot now is: {CarLot.NumberOfCars}");
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            if(String.IsNullOrEmpty(EngineNoise))
            {
                Console.WriteLine("Vroom Vroom");
            }
            else
            { 
                Console.WriteLine(EngineNoise);
            }
        }

        public void MakeHonkNoise()
        {
            if (String.IsNullOrEmpty(HonkNoise))
            {
                Console.WriteLine("Beep Beep");
            }
            else
            {
                Console.WriteLine(HonkNoise);
            }
        }
    }
}
