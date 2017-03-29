using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
         static void Main(string[] args)
        {
            //declaring variables: student information
		string firstName,lastName,birthDate,addressLine_1,addressLine_2,city,stateOrProvince,zipOrPostal,country;

		//initialising variable
		firstName="John";
		lastName="Doe";
		birthDate="22/02/1992"; //date format: dd/mm/yyyy
		addressLine_1="Makerere University";
		addressLine_2="P.O Box 7062 Kampala, Uganda";
		stateOrProvince="Kampala";
		zipOrPostal="7062";
		country="Uganda";

		//outputing the information
		Console.WriteLine("First Name: "+firstName);
		Console.WriteLine("Last Name: "+lastName);
		Console.WriteLine("Birthdate: "+birthDate);
		Console.WriteLine("Address Line 1: "+addressLine_1);
		Console.WriteLine("Address Line 2: "+addressLine_2);
		Console.WriteLine("State or Province: "+stateOrProvince);
		Console.WriteLine("Zip or Postal: "+zipOrPostal);
		Console.WriteLine("Country: "+country);
        }
    }
}
