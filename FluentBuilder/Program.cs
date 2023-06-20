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

            Console.WriteLine(  builder.ToString());
        }
    }
}