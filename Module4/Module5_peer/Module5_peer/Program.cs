using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_peer
{
    class Program
    {
        student stu1 = new student("Jhon","Adams");

student stu2 = new student("Chandler", "Bing");
student stu3 = new student("Ross", "Geller");
teacher tech1 = new teacher();
course cou1 = new course();
cou1.name = "Programming with C#";
cou1.studentArray[0] = stu1;
cou1.studentArray[1] = stu2;
cou1.studentArray[2] = stu3;
cou1.teacherArray[0] = tech1;
degree deg1 = new degree();
deg1.name = "Bachelor";
deg1.courseVar = cou1;
uProgram prog1 = new uProgram();
prog1.name = "Information Technology";
prog1.degreeVar = deg1;

Console.WriteLine("The {0} program contains the {1} degree", prog1.name, prog1.degreeVar.name);
Console.WriteLine("The {0} degree contains the {1} course", prog1.degreeVar.name, prog1.degreeVar.courseVar.name);
Console.WriteLine("The {0} course contains the {1} student", student.totalStudents);
Console.ReadLine()
    }
}
