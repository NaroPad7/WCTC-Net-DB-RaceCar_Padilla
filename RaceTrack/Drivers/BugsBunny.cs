using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BugsBunny : Driver
    {   public BugsBunny(RaceCar car) : base(car)
        {
            Name = "Bugs Bunny";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
        
    }
    
}
