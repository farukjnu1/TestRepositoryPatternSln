using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public Customer()
        {
        }
        public Customer(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
