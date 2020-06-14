using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedConversorSpecial
{
    class Calculus: SpeedConversorStandard.Calculus
    {
        public override int SpeedConversion(int parsecs, string spaceship)
        {
            return base.SpeedConversion(parsecs);
        }

        public override int SpeedConversion(int parsecs)
        {
            return parsecs * 15000;
        }
    }
}
