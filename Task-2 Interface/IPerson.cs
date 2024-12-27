using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal interface IPerson
    {
        public string fname {  get; set; }  

        public char gender { get; set; }

        public string showFacultyDetails();
    }
}
