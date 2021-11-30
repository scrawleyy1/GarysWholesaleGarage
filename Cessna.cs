using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"This Cessna is {MainColor}");
        }
        public override void Stop()
        {
            Console.WriteLine("Forgot to hit the breaks");
        }

        public override void Turn()
        {
            Console.WriteLine("Jesus take the wheeeellllll");
        }
    }
}