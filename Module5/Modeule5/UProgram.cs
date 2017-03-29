using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class UProgram
    {
        private string programName {get;set; }
        private string departmentHead{ get; set; }
        private int degrees{get;set;}
        private Degree degreeInfo;

        public UProgram() { }
         public UProgram(string name, string head,string degrees)
         {
                this.programName = name;
                this.departmentHead = head;
                this.degrees = Convert.ToInt32(degrees);
          }

         public void setProgramName(string name)
         { 
            this.programName=name;
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
}
