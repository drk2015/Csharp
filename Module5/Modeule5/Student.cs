﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Student
    {
        private string firstName{get;set;}
        private string lastName{get;set;}
        private string addressLine_1{get;set;}
        private string addressLine_2{get;set;}
        private string city{get;set;}
        private string stateOrProvince{get;set;}
        private string country{get;set;}
        private DateTime birthDate{get;set;}
        private string zipOrPostal{get;set;}
        private static int totalStudents{get;set;}
       

         //student constructor
            public Student(string fName,string lName,string bd,string add1, string add2,string city,string stateOrPr,string ctry,string zip) {
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

        public static int countStudents()
        {
            return totalStudents;
        }
    }
}
