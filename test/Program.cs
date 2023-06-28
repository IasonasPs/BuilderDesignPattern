using testStepWisebuilder;
using testStepWisebuilder.Models;

namespace testStepWisebuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cake =  CakeBuilder
                .Create()
                .ChooseFilling(filling.darkChocolate)
                .ChooseSize( cakeSize.small)
                .ChooseName("awesome")
                .Cook();

            Console.WriteLine( cake.ToString() );








        }

    }
}