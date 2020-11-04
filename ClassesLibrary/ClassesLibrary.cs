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
            return string.Format("\n-*-*-*- STUDENT -*-*-*-\n\n" +
                $"ID: {Id} | GPA: {Gpa}\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}\n\n");
        }
    }//end Student

    public class Vehicle
    {
        //fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        //ctors
        //FULLY QUALIFIED CTOR
        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        //DEFAULT CTOR
        public Vehicle() { }

        //methods
        public override string ToString()
        {
            return string.Format($"\n-*-*-*- VEHICLE -*-*-*-\n\n" +
                $"{Year} {Make} {Model}\n" +
                $"Vehicle Weight: {Weight}\n\n");
        }
    }//end Vehicle



}

