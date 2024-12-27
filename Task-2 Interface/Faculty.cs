using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Faculty:IPerson,IAddress,IContact
    {
        public int fid { get; set; }
        public string fname { get ; set ; }
        public char gender { get ; set; }
        public string City { get ; set; }
        public string Area {get ; set; }
        public string Pincode { get ; set ; }
        public string email { get ; set ; }
        public long mobile { get ; set ; }

        public Faculty() { }


        public void showFacultyID()
        {
            Console.WriteLine("Faculty ID : "+fid);
        }
        public string showFacultyDetails()
        {
            return $"FacultyName: {fname} Gender : {gender}" ;
        }

        public string IAddress()
        {
            return $"City : {City} Area: {Area} Pincode : {Pincode}";
        }

        public string displayContactDetails()
        {
            return $"Email:{email} Mobile:{mobile}";
        }
    }
}
