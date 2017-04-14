using Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        //[TestMethod]
        //public void FindTestExistingCustomer()
        //{
        //    //Arrange
        //    CustomerRepository repo = new CustomerRepository();
        //    var customerList = repo.Retrieve();

        //    //Act
        //    var result = repo.Find(customerList, 3);

        //    //Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(3, result.CustomerId);
        //    Assert.AreEqual("Marlene", result.FirstName);
        //    Assert.AreEqual("Fonseca", result.LastName);

        //}
        //[TestMethod]
        //public void FindTestNotFound()
        //{
        //    //Arrange
        //    CustomerRepository repo = new CustomerRepository();
        //    var custList = repo.Retrieve();

        //    //Act
        //    var result = repo.Find(custList, 2);

        //    //Assert 
        //    Assert.IsNull(result);
        //}

        [TestMethod]
        public void SortByNameTest()
        {
            //Arrange
            CustomerRepository repo = new CustomerRepository();

            var customerList = repo.Retrieve();

            //Act
            var result = repo.SortByName(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Lopes", result.First().LastName);
        }

        [TestMethod]
        public void GetCustomerTypeNameTest()
        {
            //Arrange
            CustomerRepository repo = new CustomerRepository();
            var customerList = repo.Retrieve();
            CustomerTypeRepository repoType = new CustomerTypeRepository();
            var customerTypeList = repoType.Retrieve();

            //Act
            var result = repo.GetCustomerTypeName(customerList, customerTypeList);



        }

        [TestMethod]
        public void GetOverdueCustumersTest()
        {
            //Arrange
            CustomerRepository repo = new CustomerRepository();
            var customerList = repo.Retrieve();


            //Act
            var result = repo.GetOverdueCustomers(customerList);

            //Analyze
            foreach (var item in result)
            {

            }

            //Assert


        }
    }
}
