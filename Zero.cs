using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }


        public override void Drive()
        {
            Console.WriteLine($"VRM VRM VRM VRM and is {MainColor}");
        }
        public override void Stop()
        {
            Console.WriteLine("HALTTTTTTT");
        }

        public override void Turn()
        {
            Console.WriteLine("Turned into Micky Dssss");
        }
        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}