using FluentBuilder.Models;
using FluentBuilderInheritanceWithRecursivegenerics.Builders;
using FluentBuilderInheritanceWithRecursivegenerics.Models;

namespace FluentBuilderInheritanceWithRecursivegenerics
{

    public class test : GenericPersonInfoBuilder<test>
    {

        public test() { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           var m = localPerson.New
                .Called("Maria")
                .WorksAsA("lawyer")
                //.Build()
                ;

            Console.WriteLine(  m.Build());
        }
    }
}