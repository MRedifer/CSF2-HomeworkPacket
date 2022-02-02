using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //FIELDS
        private string _firstName;

        private string _lastName;

        private string _id;

        private float _gpa;

        //PROPERTIES

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

        public string Identification
        {
            get { return _id; }
            set { _id = value; }
        }

        public float GradePointAvg
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //CONSTRUCTORS

        public Student(string firstName, string lastName, string id, float gpa)
        {
            //PascalCase = camelCase;
            //Property = parameter;
            FirstName = firstName;
            LastName = lastName;
            Identification = id;
            GradePointAvg = gpa;
        }

        public Student() { }

        //METHODS
        public override string ToString()
        {
            return string.Format("{0} {1}\nStudent ID: {2}\nGPA: {3}\n", FirstName, LastName, Identification, GradePointAvg);
        }


    }//end clas
}//end namespace
