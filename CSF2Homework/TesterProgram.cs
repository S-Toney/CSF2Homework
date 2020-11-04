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
            Student s1 = new Student();
            s1.FirstName = "Helen";
            s1.LastName = "Keller";
            s1.Id = "B&D1";
            s1.Gpa = 3.8f;
            Console.WriteLine(s1);

            Vehicle v1 = new Vehicle();
            v1.Year = 1999;
            v1.Make = "Jeep";
            v1.Model = "Wrangler";
            v1.Weight = 3760;
            Console.WriteLine(v1);

            Login l1 = new Login();
            l1.UserName = "hKeller";
            l1.Password = "hKB&D1";
            Console.WriteLine(l1);

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1300 S Montgomery Ave.";
            c1.City = "Sheffield";
            c1.State = "Alabama";
            c1.Zip = "35660";
            c1.Phone = "(256) 386-4196";
            c1.Email = "itsupport@helenkeller.com";
            Console.WriteLine(c1);
        }

    }
}
