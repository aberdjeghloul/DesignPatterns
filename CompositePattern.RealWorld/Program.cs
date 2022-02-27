using System;
using System.Text;

namespace CompositePattern.RealWorld
{
    /// <summary>
    /// Composite Design Pattern
    /// The term composite means a thing made of several parts or elements. Let us understand the composite design pattern in C# with one real-time example. 
    /// Here we want to assemble a computer. As we know a computer is made of several parts or elements integrated together     
    /// Computer
    ///     Cabinet
    ///         Hard Disk
    ///         Mother Board
    ///             CPU
    ///             RAM
    ///     Peripherals
    ///         Mouse
    ///         Keyboard              
    /// Everything is an object. So, here, Computer, Cabinet, Peripherals, Hard Disk, Mother Board, Mouse, Keyboard, CPU, RAM, etc. all are objects.
    /// So, in our example, the Computer, Cabinet, Peripherals, Mother Boards are composite objects while Hard Disk, CPU, RAM, Mouse, and Keyboard are the leaf object
    /// Here we are creating the tree structure and then showing the respective component price by calling the DisplayPrice method
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Encoding that includes the euro sign
            Console.OutputEncoding = Encoding.UTF8;

            //Creating Leaf objects
            IDeviceComponent keyboard = new DeviceLeaf("Keyboard", 10);
            IDeviceComponent mouse = new DeviceLeaf("Mouse", 10);
            IDeviceComponent ram = new DeviceLeaf("RAM", 60);
            IDeviceComponent cpu = new DeviceLeaf("CPU", 150);
            IDeviceComponent hardDisk = new DeviceLeaf("Hard Disk", 120);

            //Creating Composite objets
            DeviceComposite motherBoard = new DeviceComposite("Mother Board");
            DeviceComposite peripherals = new DeviceComposite("Peripherals");
            DeviceComposite cabinet = new DeviceComposite("Cabinet");
            DeviceComposite computer = new DeviceComposite("Computer");

            //Creating composite structure
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            //Adding mouse and keyboard in Peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            //Adding Hard Disk and Mother Board in Cabinet
            cabinet.AddComponent(hardDisk);
            cabinet.AddComponent(motherBoard);
            //Adding Peripherals and Cabinet in Computer
            computer.AddComponent(peripherals);
            computer.AddComponent(cabinet);

            //To display the price of Computer
            computer.DisplayPrice();
            Console.WriteLine();

            //To diplay the price of keybord
            keyboard.DisplayPrice();
            Console.WriteLine();

            //To display the price of cabinet
            cabinet.DisplayPrice();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
