using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWorld
{
    /// <summary>
    /// Leaf class. Represente low level of the tree. Each device composed the computer have a name and a price
    /// </summary>
    public class DeviceLeaf : IDeviceComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        
        public DeviceLeaf(string name,int price)
        {
            Name = name;
            Price = price;            
        }

        public void DisplayPrice()
        {
            Console.WriteLine("   " + Name + " : " + Price + " €");
        }

        public int GetTotalPrice()
        {
            return Price;
        }
    }
}
