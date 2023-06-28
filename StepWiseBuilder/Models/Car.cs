using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWiseBuilder.Models
{
    public class Car
    {
        public CarType type;
        public int WheelSize;


        public override string ToString()
        {
            return $"{type} with wheelsize of {WheelSize}";
        }
    }
}
