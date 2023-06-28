using FluentBuilder.Builders;

namespace FluentBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new PersonJobBuilder();
              builder  .WorksAsA("sdfsdf")  .Called("dfddffdf");
            //builder==>PersonJobBuilder ==> PersonInfoBuilder

            //We cant go the other way because of the order of the inheritance
            //builder==>PersonInfoBuilder==>PersonJobBuilder

            //var builder0 = new PersonJobBuilder();
            //builder0.Called("dfddffdf").WorksAsA("sdfsdf");


            Console.WriteLine(  builder.ToString());


        }
    }
}