using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritanceWithRecursivegenerics.Builders
{
    public class GenericPersonJobBuilder<T> : GenericPersonInfoBuilder<GenericPersonJobBuilder<T>>
        where T : GenericPersonJobBuilder<T>
    {
         public T WorksAsA(string position)
        {
            person.Position = position;
            return (T)this;
        }
    }
}
