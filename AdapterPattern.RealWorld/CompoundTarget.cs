using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWorld
{
    public class CompoundTarget
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;
        public virtual void Display()
        {            
            Console.WriteLine("\nCompound: Unknow ------ ");
        }
    }
}
