using FluentBuilderInheritance.Builders;

namespace FluentBuilderInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tenant = new TenantBuilder()
                .WithId("some Id")
                .WithBaseUrl("https://tenant1.local")
                .Build();

            Console.WriteLine( tenant.ToString() );


            var tenant01 = new ConfidentialTenantBuilder()
        .WithId("Test")
        .WithBaseUrl("https://tenant1.local")
        //.WithSecret("secret") //it cant find this.
        .Build();
        }
    }
}