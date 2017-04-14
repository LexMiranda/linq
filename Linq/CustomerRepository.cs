using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ClassLibrary1
{
    public class CustomerRepository
    {

        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCostumer = null;

            //foreach (var c in customerList)
            //{
            //    if (c.CustomerId == customerId)
            //    {
            //        foundCostumer = c;
            //        break;
            //    }
            //}

            /****Query Syntax*****/
            //var query = from c in customerList
            //            where c.CustomerId == customerId
            //            select c;
            //foundCostumer = query.First();

            /****Method Syntax*****/
            //foundCostumer = customerList
            //    .FirstOrDefault(c => 
            //    {//incluimos essas chaves pra multiplas linhas
            //        Debug.WriteLine(c.FirstName);
            //        return c.CustomerId == customerId;
            //    });
            /* METHOD SYNTAX  USING WHERE*/
            foundCostumer = customerList.Where(c =>
            {
                Debug.WriteLine(c.FirstName);
                Debug.WriteLine(c.LastName);
                return c.CustomerId == customerId;

            })
                .Skip(1)
                .FirstOrDefault();



            return foundCostumer;
        }
        public List<Customer> Retrieve()
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository();
            List<Customer> custList = new List<Customer> {
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Lex",
                    LastName = "Miranda",
                    EmailAdress ="lexlopes9@hotmail.com",
                    CustomerTypeId = 1,
                    InvoiceList = invoiceRepository.Retrieve(1)
        },
                new Customer()
        {
            CustomerId = 2,
                    FirstName = "Lex",
                    LastName = "Lopes",
                    EmailAdress = "lexlopes9@gmail.com",
                    CustomerTypeId = null,
                    InvoiceList = invoiceRepository.Retrieve(2)

                },
                new Customer()
        {
            CustomerId = 3,
                    FirstName = "Marlene",
                    LastName = "Gil",
                    EmailAdress = "gil@gmail.com",
                    CustomerTypeId = 1,
                    InvoiceList = invoiceRepository.Retrieve(3)
                },
                new Customer()
        {
            CustomerId = 4,
                    FirstName = "Suraia",
                    LastName = "Panzo",
                    EmailAdress = "su@gmail.com",
                    CustomerTypeId = 3,
                    InvoiceList = invoiceRepository.Retrieve(4)
                }
    };
            return custList;
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {

            return customerList.OrderBy(c => c.FirstName).ThenBy(c => c.LastName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {

            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                .ThenByDescending(c => c.CustomerTypeId);
        }

        public dynamic GetCustomerTypeName(List<Customer> customerList, List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                                            c => c.CustomerTypeId,
                                            ct => ct.CustomerTypeId,
                                            (c, ct) => new
                                            {
                                                Name = c.FirstName + " " + c.LastName,
                                                CustomerTypeName = ct.TypeName
                                            });

            foreach (var item in query)
            {
                Console.WriteLine("Nome: " + item.Name + "\n" + "Customer Type: " + item.CustomerTypeName + "\n");
            }

            return query;
        }

        public IEnumerable<IEnumerable<Invoice>> GetOverdueCustomers(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.InvoiceList.Where(i => i.IsPaid ?? false == false));
            return query;
        }


    }
}
