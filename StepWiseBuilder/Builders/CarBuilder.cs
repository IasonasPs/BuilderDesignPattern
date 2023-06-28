using StepWiseBuilder.Interfaces;
using StepWiseBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWiseBuilder.Builders
{
    public class CarBuilder
    {
        private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car car = new Car();

            public ISpecifyWheelSize OfType(CarType type)
            {
                car.type = type;
                return this;
            }
            public IBuildCar WithWheels(int Size)
            {
                switch (car.type)
                {
                    case CarType.CrossOver when Size < 17 || Size > 50:
                    case CarType.Sedan when Size < 15 || Size > 17:
                        throw new ArgumentException($"Wrong type of wheel for {car.type}");
                }
                car.WheelSize = Size;
                return this;

            }
            public Car Build()
            {
                return car;
            }
        }
        public static ISpecifyCarType Create()
        {
            return new Impl();
        }
    }
}
