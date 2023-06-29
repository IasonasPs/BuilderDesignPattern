using FluentBuilder.Builders;

namespace FluentBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new PersonJobBuilder();
            builder
                .WorksAsA("fisherman")
                .Called("Nikos")
                .Build()
                ;

            //          PersonJobBuilder ==> PersonInfoBuilder
            //The "WorkAsA()" method of the 'PersonJobBuilder' class returns a 'PersonJobBuilder' instance,
            //and because 'PersonJobBuilder' inherits from 'PersonInfoBuilder' this particular instance is also a 
            //'PersonInfoBuilder' instance which has the "Called()" method.
            //----------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------
            //          PersonInfoBuilder==>PersonJobBuilder
            //We cant go the other way because of the order of the inheritance :
            //'PersonInfoBuilder' is not a 'PersonJobBuilder' !!!

            Console.WriteLine(builder.Build());

            var builder01 = new PersonInfoBuilder();
            builder01
                .Called("Agis")
                
                ;
            Console.WriteLine(builder01.Build());
        }
    }
}