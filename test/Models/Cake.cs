using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStepWisebuilder.Models
{
    public class Cake
    {
        public string Name ;
        public filling filling;
        public cakeSize Size;

        public override string ToString()
        {
            return $"{Name} chocolate with {filling} filling and of size {Size}";
        }





    }
}
