using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"What even is a RAM {MainColor}");
        }
        public override void Stop()
        {
            Console.WriteLine("Breaks dont work");
        }

        public override void Turn()
        {
            Console.WriteLine("SWERVEEEEEE");
        }
        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}
