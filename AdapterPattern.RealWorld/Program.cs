using System;

namespace AdapterPattern.RealWorld
{
    /// <summary>
    /// Adapter Desing Pattern
    /// This real-world demonstrates the use of a legacy chemical databank.Chemical compound objects access the databank through an Adapter interface
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Non adapted chemical compound
            CompoundTarget unknown = new CompoundTarget();
            unknown.Display();

            //Adapted chemical compounds
            CompoundTarget water = new RichCompoundAdapter("Water");
            water.Display();

            CompoundTarget benzene = new RichCompoundAdapter("Benzene");
            benzene.Display();

            CompoundTarget ethanol = new RichCompoundAdapter("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}
