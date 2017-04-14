using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class InvoiceRepository
    {
        public List<Invoice> Retrieve(int id)
        {
            List<Invoice> invoiceList = new List<Invoice>
            {

                new Invoice()
                {
                    InvoiceId = 1,
                    CustomerId = 1,
                    InvoiceDate = new DateTime(2013, 6, 20),
                    DueDate = new DateTime(2013, 8, 20),
                    IsPaid = null

                },

                new Invoice()
                {
                    InvoiceId = 2,
                    CustomerId = 3,
                    InvoiceDate = new DateTime(2013, 7, 20),
                    DueDate = new DateTime(2013, 8, 20),
                    IsPaid = null

                },

                new Invoice()
                {
                    InvoiceId = 3,
                    CustomerId = 4,
                    InvoiceDate = new DateTime(2013, 6, 20),
                    DueDate = new DateTime(2013, 8, 20),
                    IsPaid = null

                },

                new Invoice()
                {
                    InvoiceId = 4,
                    CustomerId = 2,
                    InvoiceDate = new DateTime(2013, 6, 20),
                    DueDate = new DateTime(2013, 8, 20),
                    IsPaid = null

                },

            };
            List<Invoice> filtred = invoiceList.Where(i => i.CustomerId == id).ToList();
            return filtred;
        }
    }
}
