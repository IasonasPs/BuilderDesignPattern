using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBuilderInheritanceWithRecursivegenerics.Models;

namespace FluentBuilderInheritanceWithRecursivegenerics.Builders
{
    public class GenericPersonInfoBuilder<T> : PersonBuilder 
        where T : GenericPersonInfoBuilder<T>
    {
        public T Called(string name)
        {
            person.Name = name;
            return (T)this;
        }
    }
}
