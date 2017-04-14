using System.Collections.Generic;

namespace ClassLibrary1
{
    public class CustomerTypeRepository
    {
        public List<CustomerType> Retrieve()
        {
            List<CustomerType> customerTypeList = new List<CustomerType>
            {
                new CustomerType
                {
                  CustomerTypeId = 1,
                  TypeName = "Empresa",
                  DysplayOrder = 1
                },
                new CustomerType
                {
                  CustomerTypeId = 2,
                  TypeName = "Individual",
                  DysplayOrder = 4
                },
                new CustomerType
                {
                  CustomerTypeId = 3,
                  TypeName = "Governo",
                  DysplayOrder = 0
                },
                new CustomerType
                {
                  CustomerTypeId = 4,
                  TypeName = "Sócio",
                  DysplayOrder =1
                },
                new CustomerType
                {
                  CustomerTypeId = 5,
                  TypeName = "ONG",
                  DysplayOrder = 4
                },
            };
            return customerTypeList;
        }
    }
}
