using IngresoSML2.Business;
using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace IngresoSML2.UnitTests
{
    public class CustomerBusinessTest
    {
        private readonly Mock<ICustomerInterface> mock = new Mock<ICustomerInterface>();
        private CustomerBusiness cB;

        private void Setup()
        {
            var customerDTO = new CustomerDTO()
            {
                CustomerId = 1,
                FirstName = "Adam",
                LastName = "Tolosa"
            };
            List<CustomerDTO> customers = new List<CustomerDTO> { customerDTO };
            mock.Setup(x => x.GetAllCustomers()).Returns(customers);
            cB = new CustomerBusiness(mock.Object);
        }

  
       
        [Fact]
        public void TestingGetAllCustomersNotEmpty()
        {
            this.Setup();
            var result = cB.GetAllCustomers();
            Assert.NotEmpty(result);
        }


        [Fact]
        public void TestingGetAllCustomersIsType()
        {
            this.Setup();
            var result = cB.GetAllCustomers();
            Assert.IsType<List<CustomerDTO>>(result);
        }
    }
}
