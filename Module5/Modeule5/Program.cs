using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
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
            Degree d = new Degree("Bachelor",400,c1);

            //Instatiating UProgram object
            UProgram p = new UProgram();
            p.setProgramName("Information Technology");
            p.addDegree(d);

            //
            Console.WriteLine("{0} Program contains {1} degree",p.getProgramName(),p.getDegreeName(d));
            Console.WriteLine("{0} degree contains the {1} course",d.getDegreeName(),d.getCourseName(c1));
            Console.WriteLine("The {0} Course containes {1} student(s)",c1.getCourseName(),c1.countStudents());
            
        }
    }
}