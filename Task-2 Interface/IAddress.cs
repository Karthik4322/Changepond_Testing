using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
     interface IAddress
    {
        public string City { get; set; }
        public string Area { get; set; }

        public string Pincode { get; set; }

        public string IAddress();
       
    }
}
