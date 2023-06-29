using FluentBuilderInheritanceWithRecursivegenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritanceWithRecursivegenerics.Builders
{
    public class PersonBuilder
    {
        protected localPerson person = new localPerson();

        public localPerson Build()
        {
            return person;
        }
    }
}
