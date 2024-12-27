using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
     interface IContact
    {
        public string email {  get; set; }  

        public long mobile {  get; set; }

        public string displayContactDetails();
        
    }
}
