using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedConversorStandard
{
    public class Calculus
    {
        public virtual int SpeedConversion(int parsecs)
        {
            return parsecs*1500;
        }

        public virtual int SpeedConversion(int parsecs, string spaceship)
        {
            int kms = parsecs * 1500;

            if (spaceship == "XW")
            {
                kms *= 3; 
            }   
            else if (spaceship == "CS")
            {
                kms *= 2; 
            }

            return kms;
        }
    }
}
