using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.BL;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness(new CustomerRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Customer> _listCustomer = customerBusiness.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("ID   |   Name    |   Address");
                        foreach (Customer _customer in _listCustomer)
                        {
                            Console.WriteLine(_customer.Id + "  |   " + _customer.Name + "  |   " + _customer.Address);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a customer:");
                        string id = Console.ReadLine();
                        Customer aCstomer = customerBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aCstomer.Id + ". " + aCstomer.Name + " -- " + aCstomer.Address);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Customer aCustomer = new Customer();
                        aCustomer.Id = Convert.ToInt32(id);
                        aCustomer.Name = name;
                        aCustomer.Address = address;
                        bool isExecuted = customerBusiness.Add(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Customer aCustomer = new Customer();
                        aCustomer.Id = Convert.ToInt32(id);
                        aCustomer.Name = name;
                        aCustomer.Address = address;
                        bool isExecuted = customerBusiness.Update(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = customerBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            //Console.ReadKey();
        }
    }
}
