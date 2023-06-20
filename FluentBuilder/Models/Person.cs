using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder.Models
{
    public class Person
    {
        public string Name;
        public string Position;
        public override string ToString()
        {
            return $"{nameof(Name)} : {Name} and {nameof(Position)} : {Position}";
        }
    }
}
