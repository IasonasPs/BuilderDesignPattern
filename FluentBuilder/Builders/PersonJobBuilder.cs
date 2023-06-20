using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder.Builders
{
    public class PersonJobBuilder : PersonInfoBuilder
    {
        public PersonJobBuilder WorksAsA(string position)
        { 
            person.Position = position;
            return this; 
        }

        public override string ToString()
        {
            return $"{person.Name} ++++ {person.Position}";
        }
    }
}
