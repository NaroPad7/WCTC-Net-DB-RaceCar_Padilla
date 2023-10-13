using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceTrack.RaceTrack.Cars
{
    public class Motorcycle : RaceCar
    {
        public Motorcycle()
        {
            Name = "Motorcycle";
            TopSpeed = 110;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts right up");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine has seized");
            base.StopEngine();
        }
    }
}
