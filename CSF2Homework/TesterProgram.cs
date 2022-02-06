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
            Customer u1 = new Customer("0542", "Michael", "Redifer", c1);
            Console.WriteLine(c1);
            CreditCardAccount cca1 = new CreditCardAccount(987654321, u1, Convert.ToDecimal(12546.33), false, Convert.ToDecimal(3.3));
            Console.WriteLine(cca1);
            Book b1 = new Book("Berserk", "Kentaro Miura", 9200);
            Console.WriteLine(b1);
            List<Book> books1 = new List<Book>();
            books1.Add(b1);
            Library li1 = new Library("Olathe Public Library", "12345 main street", "Olathe", "Kansas", "66062", books1);
            Song so1 = new Song("Tool", "Forty Six & 2", 342);
            Song so2 = new Song("Tool", "Ænima", 417);
            Console.WriteLine(so1);


        }//end main
    }//end class
}//end namespace
