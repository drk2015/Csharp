using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instatiating 3 student objects
            Student s1 = new Student("John", "Doe", "20/Feb/1992", "BB suites", "123 Main Street", "New York", "New York", "USA", "123 NY");
            Student s2 = new Student("Musoke", "Joseph", "14/Feb/1990", "Makerere University", "P.O Box 7062 Kampala, Uganda", "Kampala", "Wakiso", "Uganda", "7062 KLA");
            Student s3 = new Student("Kasibante", "Geoffrey", "20/Feb/1991", "BD suites", "123 Main Street", "Los Angeles", "Los Angeles", "LA", "123 LA");


            //Addding scores to student 1
            s1.addScore(51.2);
            s1.addScore(61.0);
            s1.addScore(71.1);
            s1.addScore(81.1);
            s1.addScore(81.1);
            //Adding scores to student 2
            s2.addScore(52.2);
            s2.addScore(72.0);
            s2.addScore(82.2);
            s2.addScore(62.2);
            s2.addScore(52.2);
            //Adding scores to student 3
            s2.addScore(53);
            s2.addScore(73.3);
            s2.addScore(83.3);
            s2.addScore(63.3);
            s2.addScore(53.3);

            //Instatiating Course object
            Course c1 = new Course("Programming With CSharp");

            //Adding students to Course Object
            c1.addStudent(s1);
            c1.addStudent(s2);
            c1.addStudent(s3);

            //List students 
            c1.ListStudents();
        }
    }

    #region StudentClass
    class Student
    {
        private string firstName;
        private string lastName;
        private string addressLine_1;
        private string addressLine_2;
        private string city;
        private string stateOrProvince;
        private string country;
        private DateTime birthDate;
        private string zipOrPostal;
        private static int totalStudents;
        private Stack grades = new Stack();

        //accessors
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string AddressLine_1
        {
            get { return addressLine_1; }
            set { addressLine_1 = value; }
        }

        public string AddressLine_2
        {
            get { return addressLine_2; }
            set { addressLine_2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string StateOrProvince
        {
            get { return stateOrProvince; }
            set { stateOrProvince = value; }
        }

        public string ZipOrPostal
        {
            get { return zipOrPostal; }
            set { zipOrPostal = value; }
        }

        //student constructor
        public Student(string fName, string lName, string bd, string add1, string add2, string city, string stateOrPr, string ctry, string zip)
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
            totalStudents++; //variable to count student objects
        }

        //count Students
        public static int countStudents()
        {
            return totalStudents;
        }

        //Add score to student
        public void addScore(double score)
        {
            grades.Push(score);
        }

    }
    #endregion

    #region Course Class
    class Course
    {
        private string courseName { get; set; }
        private string teacher { get; set; }
        private double credits { get; set; }
        private double durationInWeeks { get; set; }

        //Array of student object
        private ArrayList studentArr = new ArrayList();

        public ArrayList StudentArr
        {
            get { return studentArr; }
            set { studentArr = value; }
        }

        //Array of teacher object
        private ArrayList teacherArr = new ArrayList();

        public ArrayList TeacherArr
        {
            get { return teacherArr; }
            set { teacherArr = value; }
        }

        //Coourse Constructor
        public Course(string name)
        {
            this.courseName = name;
        }

        //Add Student method
        public void addStudent(Student s)
        {
            this.studentArr.Add(s);
        }

        //List Students
        public void ListStudents()
        {
            Console.WriteLine("Students taking {0}", getCourseName());
            foreach (Student s in StudentArr)
            {
                Console.WriteLine("{0} {1}", s.FirstName, s.LastName);
            }
        }

        //Return CourseName
        public string getCourseName()
        {
            return this.courseName;
        }

    }
    #endregion
}