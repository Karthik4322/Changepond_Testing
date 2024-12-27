//using System;

//namespace tasks
//{

//    class Person
//    {
//        public string Name;

//    public Person(string fname)
//     {
//            this.Name = fname;
//     }
//        public override string ToString()
//        {
//            return this.Name;
//        }

//    }
//     class Program
//    {
//        public static void Main(string[] args)
//        {
//            Person[] person = new Person[3];
//            //person[0] = new Person("Juan");
//            //person[1] = new Person("Sara");
//            //person[2] = new Person("Carlos");

//            for (int i = 0; i < person.Length; i++)
//            {
//                Console.WriteLine($"Enter the names for the {i + 1} person");
//                string fname = Console.ReadLine();
//                person[i] = new Person(fname);
//            }
//            Console.WriteLine("List of names are: ");
//            foreach (Person p in person) {
//                Console.WriteLine(p);
//            }
           

//        }
//    }
//}
