using IngresoSML2.Business;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IngresoSML2.UnitTests
{
    public class InvoiceItemsTest
    {

        private readonly Mock<IInvoiceItemsInterface> mock = new Mock<IInvoiceItemsInterface>();
        private InvoiceItemsBusiness iIB;
        private  InvoiceDTO iDTO;

        private void Setup()
        {
            List<string> codes = new List<string>();
                
            iDTO = new InvoiceDTO()
            {
                CustomerId = 1,
                Codes = codes
            };

            var invoiceItem = new InvoiceItem()
            {
                ProductCode = "Product1"
            };
            List<InvoiceItem> invoiceItems = new List<InvoiceItem> { invoiceItem };
            mock.Setup(x => x.AddInvoiceItems(invoiceItems)).Returns(1);
            iIB = new InvoiceItemsBusiness(mock.Object);
        }



        [Fact]
        public void TestingCreateInvoiceItemNotEmpty()
        {
            this.Setup();
            var result = iIB.CreateInvoiceItems(1, iDTO);
            Assert.IsType<ResponseDTO>(result);
        }
    }
}

