using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }

    }

    public class Customer: CustomerBase
    {
    }

    public class Lead: CustomerBase
    {

    }
}
