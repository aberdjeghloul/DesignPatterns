using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWorld
{
    /// <summary>
    /// Computer is composed with electronic objects: cabinet, peripherals, hard disk, mother board, mouse, keyboard, cpu, ram
    /// Each of them have a price.
    /// </summary>
    public interface IDeviceComponent
    {        
        void DisplayPrice();
        int GetTotalPrice();
    }
}
