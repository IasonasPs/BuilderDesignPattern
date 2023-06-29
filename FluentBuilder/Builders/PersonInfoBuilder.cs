using FluentBuilder.Interfaces;
using FluentBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder.Builders
{
    public  class PersonInfoBuilder : PersonBuilder
    {
        public PersonInfoBuilder Called(string name)
        {
            person.Name = name;
            return this;
        }
    }
}
