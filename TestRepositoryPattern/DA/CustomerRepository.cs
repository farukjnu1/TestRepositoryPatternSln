using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> listCustomer = new List<Customer>()
        {
            new Customer(1, "H&M", "USA"),
            new Customer(2, "Armany", "Armania"),
            new Customer(3, "Nike", "Germany"),
            new Customer(4, "Addidas", "Russia")
        };
        public List<Customer> Get()
        {
            // Simulate returning the list of data from the database.
            // SqlConnection code would actually go here, this is to keep things simple.
            return listCustomer.OrderBy(x => x.Name).ToList();
        }

        public Customer Get(int id)
        {
            Customer oCustomer = listCustomer.Where(x => x.Id == id).FirstOrDefault();
            return oCustomer;
        }

        public bool Add(Customer model)
        {
            listCustomer.Add(model);
            return true;
        }

        public bool Update(Customer model)
        {
            bool isExecuted = false;
            Customer oCustomer = listCustomer.Where(x => x.Id == model.Id).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                listCustomer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete (int id)
        {
            bool isExecuted = false;
            Customer oCustomer = listCustomer.Where(x => x.Id == id).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
