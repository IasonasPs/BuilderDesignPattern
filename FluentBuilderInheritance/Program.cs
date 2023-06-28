using FluentBuilderInheritance.Builders;
using FluentBuilderInheritance.models;
using System.Security.Cryptography.X509Certificates;

namespace FluentBuilderInheritance
{
    internal class Program
    {
        public class test : ConfidentialTenantBuilder<test>
        {

        }
        static void Main(string[] args)
        {


            var tenant = new test()
                .WithId("some Id")
                .WithSecret("123123")
                .WithBaseUrl("https://tenant1.local")
                .Build();

            Console.WriteLine(tenant.ToString());



        }
    }
}