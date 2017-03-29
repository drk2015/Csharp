using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        struct student 
        {
            string firstName, lastName, addressLine_1, addressLine_2, city, stateOrProvince, country, zipOrPostal;
            DateTime birthDate;

            //student constructor
            public student(string fName,string lName,string bd,string add1, string add2,string city,string stateOrPr,string ctry,string zip) {
                this.firstName = fName;
                this.lastName = lName;
                this.birthDate = Convert.ToDateTime(bd);
                this.addressLine_1 = add1;
                this.addressLine_2 = add2;
                this.city = city;
                this.stateOrProvince = stateOrPr;
                this.country = ctry;
                this.zipOrPostal = zip;  
            }

            public void getStudent()
            {
                Console.WriteLine("Name: {0} {1}\nBirth Date: {2}\nAddress: {3} {4}\nCity:{5}\nState or Province: {6}\nCountry: {7}\nZip or Postal Code: {8}",firstName,lastName,String.Format("{0:dd-MMM-yyyy}",birthDate),addressLine_1,addressLine_2,city,stateOrProvince,country,zipOrPostal);
            }

        }
        struct teacher
        {
            string firstName, lastName, addressLine_1, addressLine_2, city, stateOrProvince, country, zipOrPostal;
            DateTime birthDate; 
             //teacher constructor
            public teacher(string fName, string lName,string bd, string add1, string add2, string city, string stateOrPr, string ctry, string zip)
            {
                this.firstName = fName;
                this.lastName = lName;
                this.birthDate = Convert.ToDateTime(bd);
                this.addressLine_1 = add1;
                this.addressLine_2 = add2;
                this.city = city;
                this.stateOrProvince = stateOrPr;
                this.country = ctry;
                this.zipOrPostal = zip;
            }

        };

        struct program
        {
            string programName, departmentHead;
            int degrees;
            //program constructor
            public program(string pName, string dH,string deg)
            {
                this.programName = pName;
                this.departmentHead = dH;
                this.degrees = Convert.ToInt32(deg);
            }
        };

        struct course
        {
            string courseName, teacher;
            double credits, durationInWeeks;
            //course constructor
            public course(string cName,string tr,string credits,string duration)
            {
                this.courseName = cName;
                this.teacher = tr;
                this.credits = Convert.ToDouble(credits);
                this.durationInWeeks = Convert.ToDouble(duration);
            }
        };

        public static void Main(string[] args)
        {
            //Array of student struct
            student[] studentArr = new student[5];

            //Initialisiing Array
            studentArr[0] = new student("John", "Doe", "20/Feb/1992", "BB suites", "123 Main Street", "New York", "New York", "USA", "123 NY");
            studentArr[1] = new student("Musoke","Joseph","14/Feb/1990","Makerere University","P.O Box 7062 Kampala, Uganda","Kampala","Wakiso","Uganda","7062 KLA");

            //Writing value of struct
            Console.WriteLine("Student 1\n===========");
            studentArr[0].getStudent();
            Console.WriteLine("\nStudent 2\n===========");
            studentArr[1].getStudent();
        }
    }
}
