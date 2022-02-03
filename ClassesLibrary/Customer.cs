using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //FIELDS
        private string _customerID;

        private string _firstName;

        private string _lastName;

        

        //PROPERTIES

        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public ContactInfo ContactInfoG { get; set; }

        //CONSTRUCTORS

        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInfoG)
        {
            //PascalCase = camelCase;
            //Property = parameter;
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInfoG = contactInfoG;
        }

        public Customer() { }

        //METHODS
        public override string ToString()
        {
            return string.Format("Customer ID: {0}\nFirst Name: {1}\nLast Name: {2}\n Contact Info: \t\t{3}", CustomerID, FirstName, LastName, ContactInfoG);
        }
    }//end class
}//end namespace
