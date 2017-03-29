using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            mainMenu();
        }

        public static void mainMenu()
        {
            Console.WriteLine("Main Menu\n===========");
            Console.WriteLine("1. {0}\n2. {1}\n3. {2}", "Enter Information", "Print Information", "Quit");
            string m = Console.ReadLine();
            switch (m)
            {
                case "1": dataMenu(); break;
                case "2": printMenu(); break;
                case "3": ; break;
                default: mainMenu(); break;
            }
        }
        static void dataMenu()
        {
            Console.WriteLine("Data Menu\n===========");
            Console.WriteLine("1. {0}\n2. {1}\n3. {2}\n4. {3}\n5. {4}\n0. {5}", "Student", "Teacher", "UProgram", "Course", "Degree", "Main Menu");
            string p = Console.ReadLine();
            switch (p)
            {
                case "1": Student.GetStudentInformation(); dataMenu(); break;
                case "2": Teacher.GetTeacherInformation(); dataMenu(); break;
                case "3": UProgram.GetUProgramInformation(); dataMenu(); break;
                case "4": Course.GetCourseInformation(); dataMenu(); break;
                case "5": Degree.GetDegreeInformation(); dataMenu(); break;
                case "0": mainMenu(); break;
                default: dataMenu(); break;
            }
        }

        static void printMenu()
        {
            Console.WriteLine("Print Menu\n===========");
            Console.WriteLine("1. {0}\n2. {1}\n3. {2}\n4. {3}\n5. {4}\n0. {5}", "Student", "Teacher", "UProgram", "Course", "Degree", "Main Menu");
            string p = Console.ReadLine();
            switch (p)
            {
                case "1": Student.PrintStudentDetails(); printMenu(); break;
                case "2": Teacher.PrintTeacherDetails(); printMenu(); break;
                case "3": UProgram.PrintUProgramDetails(); printMenu(); break;
                case "4": Course.PrintCourseDetails(); printMenu(); break;
                case "5": Degree.PrintDegreeDetails(); printMenu(); break;
                case "0": mainMenu(); break;
                default: printMenu(); break;
            }
        }

    }

    class Student
    {

        static string firstName, lastName, addressLine_1, addressLine_2, city, stateOrProvince, country;
        static DateTime birthDate;
        static int zipOrPostal;
        public static void GetStudentInformation()
        {
            Console.WriteLine("Enter the Student Information: \n=======================");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Birth Date: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Address Line 1: ");
            addressLine_1 = Console.ReadLine();
            Console.Write("Address Line 2: ");
            addressLine_2 = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State or Province: ");
            stateOrProvince = Console.ReadLine();
            Console.Write("Zip or Postal: ");
            zipOrPostal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Country: ");
            country = Console.ReadLine();
        }
        public static void PrintStudentDetails()
        {

            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthDate);
            Console.WriteLine("Address: {0} {1}", addressLine_1, addressLine_2);
            Console.WriteLine("Lives in {0}, {1}, {2}, {3}", city, stateOrProvince, zipOrPostal, country);
        }
    }

    class Teacher
    {
        static string firstName, lastName, addressLine_1, addressLine_2, city, stateOrProvince, country;
        static DateTime birthDate;
        static int zipOrPostal;
        public static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the Teacher Information: \n=======================");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Birth Date: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Address Line 1: ");
            addressLine_1 = Console.ReadLine();
            Console.Write("Address Line 2: ");
            addressLine_2 = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State or Province: ");
            stateOrProvince = Console.ReadLine();
            Console.Write("Zip or Postal: ");
            zipOrPostal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Country: ");
            country = Console.ReadLine();
        }
        public static void PrintTeacherDetails()
        {

            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthDate);
            Console.WriteLine("Address: {0} {1}", addressLine_1, addressLine_2);
            Console.WriteLine("Lives in {0}, {1}, {2}, {3}", city, stateOrProvince, zipOrPostal, country);
        }
    }

    class UProgram
    {
        static string programName, departmentHead;
        static int degrees;
        public static void GetUProgramInformation()
        {
            Console.WriteLine("Enter University Program information:\n=======================");
            Console.Write("Programme Name: ");
            programName = Console.ReadLine();
            Console.Write("Department Head: ");
            departmentHead = Console.ReadLine();
            Console.Write("Degrees: ");
            degrees = Convert.ToInt32(Console.ReadLine());
        }
        public static void PrintUProgramDetails()
        {
            Console.WriteLine("University Programme information:\n=======================");
            Console.WriteLine("{0} course is headed by {1} and has {2} degrees", programName, departmentHead, degrees);

        }
    }


    class Degree
    {

        static string degreeName;
        static double creditsRequired;
        public static void GetDegreeInformation()
        {

            Console.WriteLine("Enter Degree information:\n=======================");
            Console.Write("Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Credits Required: ");
            creditsRequired = Convert.ToDouble(Console.ReadLine());
        }

        public static void PrintDegreeDetails()
        {

            Console.WriteLine("Degree information:\n=======================");
            Console.Write("Degree Name:{0}", degreeName);
            Console.Write("Credits Required: {0}", creditsRequired);
        }
    }

    class Course
    {
        static string courseName, teacher;
        static double credits, durationInWeeks;
        public static void GetCourseInformation()
        {
            Console.WriteLine("Course information:\n=======================");
            Console.Write("Course Name: ");
            courseName = Console.ReadLine();
            Console.Write("Teacher: ");
            teacher = Console.ReadLine();
            Console.Write("Credits Required: ");
            credits = Convert.ToDouble(Console.ReadLine());;
            Console.Write("Duration in weeks: ");
            durationInWeeks = Convert.ToDouble(Console.ReadLine());
        }

        public static void PrintCourseDetails()
        {
            Console.WriteLine("Program information:\n=======================");
            Console.Write("Course Name: {0}", courseName);
            Console.Write("Teacher: {0}", teacher);
            Console.Write("Credits Required: {0}", credits);
            Console.Write("Duration in weeks: {0}", durationInWeeks);
        }
    }
}