using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testStepWisebuilder.Models;

namespace testStepWisebuilder.Interfaces
{
    public interface IChooseFilling
    {
        IChooseSize ChooseFilling(filling filling);
    }
}
