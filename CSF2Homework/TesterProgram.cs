using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesLibrary;



namespace CSF2Homework
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Michael", "Redifer", "2450", 3);
            Console.WriteLine(s1);
            Console.WriteLine();
            Vehicle v1 = new Vehicle("Honda", "Civic Si", 2020, 2900);
            Console.WriteLine(v1);
            Console.WriteLine();
            Login l1 = new Login("Redifer", "TKCRED1fer123");
            Console.WriteLine(l1);
            Console.WriteLine();
            ContactInfo c1 = new ContactInfo("14345 west 116th street", "Olathe", "Kansas", "66062", "913-731-9809", "mikeredifer@yahoo.com");


        }//end main
    }//end class
}//end namespace
