using StepWiseBuilder.Builders;

namespace StepWiseBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var car = CarBuilder.Create()
                .OfType(Models.CarType.CrossOver)
                .WithWheels(42)
                .Build();

            Console.WriteLine(  car.ToString());






        }
    }
}