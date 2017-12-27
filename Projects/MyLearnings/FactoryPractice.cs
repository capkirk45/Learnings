using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPractice
{
    public static class FactoryPracticeClient
    {

        public static void ReadInvoice()
        {
            Console.WriteLine("Enter 1 for Invoices with Headers.  Enter 2 for Invoices no Headers");
            var invoiceTypeInput = Console.ReadKey();
            IInvoice invoice;
            invoice = InvoiceFactory.GetInvoice(invoiceTypeInput.KeyChar.ToString());
        }
    }

    public interface IInvoice
    {
        void Print();
    }

    public class InvoiceFactory
    {
        static public IInvoice GetInvoice(string type)
        {
            IInvoice invoice;
            if (type == "1")
            {
                invoice = new InvoiceWithHeader();
            }
            else if (type == "2")
            {
                invoice = new InvoiceWithoutHeader();
            }
            else
            {
                return null;
            }
            return invoice;
        }
    }

    public class InvoiceWithHeader: IInvoice
    {
        public InvoiceWithHeader() { }
        public void Print() { }
    }

    public class InvoiceWithoutHeader: IInvoice
    {
        public InvoiceWithoutHeader() { }
        public void Print() { }
    }

}

