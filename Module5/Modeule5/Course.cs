
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module5
{
    class Course
    {
        private string courseName{get;set;}
        private string teacher{get;set;}
        private double credits{get;set;}
        private double durationInWeeks{get;set;}
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
                int currentCount=Student.countStudents();
                studentArr[currentCount-1] = s;
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
