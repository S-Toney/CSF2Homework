using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
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
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //ctors
        //FULLY QUALIFIED CTOR
        public Student(string firstname, string lastname, string id, float gpa)
        {
            FirstName = firstname;
            LastName = lastname;
            Id = id;
            Gpa = gpa;
        }
        //DEFAULT CTOR
        public Student() { }

        //methods
        public override string ToString()
        {
            return string.Format("-*-*-*- STUDENT -*-*-*-\n" +
                $"ID: {Id} | GPA: {Gpa}" +
                $"First Name: {FirstName}" +
                $"Last Name: {LastName}");
        }
    }
}
