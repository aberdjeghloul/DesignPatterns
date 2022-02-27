using System;

namespace PrototypePattern
{
    public class Address
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public Address Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
