using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_peer
{
    public class student
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthdate { get; set; }

        public static int totalStudents = 0;

        public student(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
            totalStudents += 1;
        }

    }
}
