using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWorld
{
    /// <summary>
    /// Device composite class. Used to hold child components and his name 
    /// </summary>
    public class DeviceComposite : IDeviceComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }

        List<IDeviceComponent> components = new List<IDeviceComponent>();

        public DeviceComposite(string name)
        {
            Name = name;
        }

        public void AddComponent(IDeviceComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name + " Total price: " + GetTotalPrice());
            foreach (IDeviceComponent component in components)
            {                
                component.DisplayPrice();
            }
        }

        public int GetTotalPrice()
        {
            int total = 0;
            foreach (IDeviceComponent component in components)
            {
                total += component.GetTotalPrice();
            }
            return total;
        }
    }
}
