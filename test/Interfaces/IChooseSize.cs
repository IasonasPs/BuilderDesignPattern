using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testStepWisebuilder.Models;

namespace testStepWisebuilder.Interfaces
{
    public interface IChooseSize
    {
        IChooseName ChooseSize(cakeSize size);
    }
}
