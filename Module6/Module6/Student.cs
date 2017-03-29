using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Student : Person
    {

        private static int totalStudents { get; set; }


        //student constructor
        public Student(string fName, string lName, string bd, string add1, string add2, string city, string stateOrPr, string ctry, string zip)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = Convert.ToDateTime(bd);
            this.AddressLine_1 = add1;
            this.AddressLine_2 = add2;
            this.City = city;
            this.StateOrProvince = stateOrPr;
            this.Country = ctry;
            this.ZipOrPostal = zip;
            totalStudents++; //variable to count student objects
        }

        public static int countStudents()
        {
            return totalStudents;
        }

        public void TakeTest()
        {
            Console.WriteLine("TakeTest Method running...");
        }


    }
}
