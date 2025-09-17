using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern.BL
{
    public class CustomerBusiness
    {
        ICustomerRepository _repository;

        public CustomerBusiness(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public List<Customer> Get()
        {
            return _repository.Get();
        }

        public Customer Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Customer model)
        {
            return _repository.Add(model);
        }

        public bool Update(Customer model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
