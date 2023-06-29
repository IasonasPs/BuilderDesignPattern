using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBuilder.Builders;
using FluentBuilder.Models;
using FluentBuilderInheritanceWithRecursivegenerics.Builders;

namespace FluentBuilderInheritanceWithRecursivegenerics.Models
{
    public class localPerson : Person
    {
        public class Builder : GenericPersonJobBuilder<Builder>
        {

        }
        public static Builder New => new Builder(); 
    }
}
