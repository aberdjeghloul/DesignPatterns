using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWorld
{
    public class RichCompoundAdapter : CompoundTarget
    {
        private string _chemical;
        private ChemicalDataBankAdaptee bank;

        // the constructor
        public RichCompoundAdapter(string chemical)
        {
            _chemical = chemical;
        }

        public override void Display()
        {
            //The Adaptee
            bank = new ChemicalDataBankAdaptee();

            boilingPoint = bank.GetCriticalPoint(_chemical, "B");
            meltingPoint = bank.GetCriticalPoint(_chemical, "M");
            molecularWeight = bank.GetMolecularWeight(_chemical);
            molecularFormula = bank.GetMolecularStructure(_chemical);

            Console.WriteLine("\nCompound: {0} -------", _chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight: {0}", molecularWeight);
            Console.WriteLine(" Melting: {0}", meltingPoint);
            Console.WriteLine(" Boiling: {0}", boilingPoint);
        }
    }
}
