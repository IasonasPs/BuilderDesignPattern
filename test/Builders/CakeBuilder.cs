using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testStepWisebuilder.Interfaces;
using testStepWisebuilder.Models;

namespace testStepWisebuilder
{
    public class CakeBuilder 
    {
         private class Cooking : IChooseFilling, IChooseSize, IChooseName, ICookCake
        {

            Cake cake =  new Cake();

            public IChooseSize ChooseFilling(filling filling)
            {
                cake.filling = filling;
                return this;
            }

            public IChooseName ChooseSize(cakeSize size)
            {
                cake.Size = size;
                return this;
            }
            public ICookCake ChooseName(string name)
            {
                cake.Name = name;
                return this;
            }

            public  Cake Cook()
            {
                return cake;
            }
        }


        

      public static  IChooseFilling Create()
        {
            return new Cooking();
        }


    }
}
