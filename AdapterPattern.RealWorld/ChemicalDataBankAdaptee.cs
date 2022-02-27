using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWorld
{
    /// <summary>
    /// The Adaptee class
    /// </summary>
    public class ChemicalDataBankAdaptee
    {
        /// <summary>
        /// The databank legacy API
        /// </summary>
        /// <param name="compound">water, benzene or ethanol</param>
        /// <param name="point">M for Melting or B for Boiling</param>
        /// <returns></returns>
        public float GetCriticalPoint(string compound, string point)
        {            
            if (point == "M") //Melting Point
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            else //Boiling Point
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}
