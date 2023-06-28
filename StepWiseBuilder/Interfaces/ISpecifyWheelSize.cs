using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWiseBuilder.Interfaces
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int Size);
    }
}
