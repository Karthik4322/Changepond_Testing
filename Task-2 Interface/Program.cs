using System;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
           Faculty f1 = new Faculty();

          f1.fid = 1;
          f1.fname = "Dhinakaran";
          f1.gender = 'M';
          f1.showFacultyID();
          Console.WriteLine(f1.showFacultyDetails());
          f1.Area = "Vettuvankeni";
          f1.City = "Chengalpattu";
          f1.Pincode = "6000115";
          Console.WriteLine(f1.IAddress());
          f1.email = "dhinapalani999@gmail.com";
          f1.mobile = 8056013242;
          Console.WriteLine(f1.displayContactDetails());


        }
    }
}