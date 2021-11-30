using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"Vroom vrooooommmmm {MainColor}");
        }

        public override void Stop()
        {
            Console.WriteLine("SKRRRRRRTTTTTTT");
        }

        public override void Turn()
        {
            Console.WriteLine("You missed your turn idiot");
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}