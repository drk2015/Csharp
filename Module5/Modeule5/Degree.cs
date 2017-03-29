using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Degree
    {

        private string degreeName{get;set;}
        private double creditsRequired{get;set;}
        private Course courseInfo{get;set;}
        
        //Degree constructutor to initialise course
        public Degree(string name, double credits,Course c)
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
}
