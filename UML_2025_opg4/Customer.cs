using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2025_opg4
{
    public class Customer
    {
        private static int _nextNumber = 0;
        private int _number;

        public int Number
        {
            get { return _number; }
            private set { _number = value; }
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public Customer(string name, string address, string mobile)
        {
            _nextNumber++;
            Number = _nextNumber;
            Name = name;
            Address = address;
            Mobile = mobile;
        }

        public override string ToString()
        {
            return $"{Number} {Name} {Address} {Mobile}";
        }

    }
}
