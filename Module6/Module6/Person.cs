using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Person
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
    }

    //Main
    class Program
    {
        public static void Main(string[] args)
        {

            //Instatiating 3 student objects
            Student s1 = new Student("John", "Doe", "20/Feb/1992", "BB suites", "123 Main Street", "New York", "New York", "USA", "123 NY");
            Student s2 = new Student("Musoke", "Joseph", "14/Feb/1990", "Makerere University", "P.O Box 7062 Kampala, Uganda", "Kampala", "Wakiso", "Uganda", "7062 KLA");
            Student s3 = new Student("John", "Doe", "20/Feb/1991", "BD suites", "123 Main Street", "Los Angeles", "Los Angeles", "LA", "123 LA");

            //Instatiating Course object
            Course c1 = new Course("Programming With CSharp");

            //Adding students to Course Object
            c1.addStudent(s1);
            c1.addStudent(s2);
            c1.addStudent(s3);

            //Instatianting teacher object
            Teacher t1 = new Teacher("Sarah", "Becks", "20/Apr/1970", "BD suites", "123 Main Street", "Los Angeles", "Los Angeles", "LA", "123 LA");
            Teacher t2 = new Teacher("Joseph", "Zuck", "20/Jun/1950", "BD suites", "123 Main Street", "Los Angeles", "Los Angeles", "LA", "123 LA");

            //adding teachers to Course Object
            c1.addTeacher(t1);
            c1.addTeacher(t2);

            //instatitiating degree object and adding Course Object to degree
            Degree d = new Degree("Bachelor", 400, c1);

            //Instatiating UProgram object
            UProgram p = new UProgram("Information Technology");
            p.addDegree(d);

            //writing console statements
            Console.WriteLine("{0} Program contains {1} degree", p.getProgramName(), p.getDegreeName(d));
            Console.WriteLine("{0} degree contains the {1} course", d.getDegreeName(), d.getCourseName(c1));
            Console.WriteLine("The {0} Course containes {1} student(s)", c1.getCourseName(), c1.countStudents());
        }
    }

    class Degree
    {

        private string degreeName { get; set; }
        private double creditsRequired { get; set; }
        private Course courseInfo { get; set; }

        //Degree constructutor to initialise course
        public Degree(string name, double credits, Course c)
        {
            degreeName = name;
            creditsRequired = credits;
            courseInfo = c;
        }

        public string getDegreeName()
        {
            return degreeName;
        }

        public string getCourseName(Course c)
        {
            return c.getCourseName();
        }
    }
    class UProgram
    {
        private string programName { get; set; }
        private string departmentHead { get; set; }
        private int degrees { get; set; }
        private Degree degreeInfo;


        public UProgram(string name = "", string head = "", string degrees = "0")
        {
            this.programName = name;
            this.departmentHead = head;
            this.degrees = Convert.ToInt32(degrees);
        }

        public void setProgramName(string name)
        {
            this.programName = name;
        }

        public string getProgramName()
        {
            return programName;
        }


        //Method to add Degree
        public void addDegree(Degree d)
        {
            this.degreeInfo = d;
        }

        public string getDegreeName(Degree d)
        {
            return d.getDegreeName();
        }

    }



    class Course
    {
        private string courseName { get; set; }
        private string teacher { get; set; }
        private double credits { get; set; }
        private double durationInWeeks { get; set; }
        //Array of student object
        private Student[] studentArr = new Student[3];
        //Array of student object
        private Teacher[] teacherArr = new Teacher[3];


        public Course(string name)
        {
            this.courseName = name;
        }
        public void addStudent(Student s)
        {
            if (studentArr.Length < 4)
            {
                int currentCount = Student.countStudents();
                studentArr[currentCount - 1] = s;
            }
        }

        public int countStudents()
        {
            return Student.countStudents();
        }

        public void addTeacher(Teacher t)
        {
            if (teacherArr.Length < 4)
            {
                int currentCount = Student.countStudents();
                teacherArr[currentCount - 1] = t;
            }
        }

        public string getCourseName()
        {
            return courseName;
        }

    }
}

