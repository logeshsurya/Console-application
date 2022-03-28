/* EMPLOYEE APPLICATION
DESCRIPTION: Employee application thats read input from the user and validates those inputs  
AUTHOR     : Logesh Kumar k
MODIFIED ON: 29/10/2021
REVIEWD BY : Jaya and Akshaya
*/

using System;
using System.Collections.Generic;

namespace Employee
{
    public class EmployeeApplicationForm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("                WELCOME TO ASPIRE SYSTEMS!");

            //Choose the operation that we need to do
            EmployeeApp();

        }
        public static void EmployeeApp()
        {


            //Select the choice to perform the task
            Console.WriteLine("1)ADD EMPLOYEE DETAILS\n2)READ A SPECIFIC EMPLOYEE\n3)UPDATE EMPLOYEE DETAILS\n4)DISPLAY EMPLOYEE DETAILS\n5)DELETE EMPLOYEE DETAILS\n6)EXIT\nPLEASE ENTER A VALID CHOICE");
            int Choice = Convert.ToInt32(Console.ReadLine());
            // to interact with the other class 
            //validation.ChooseOperation(Choice);
            EmployeeInformation employeeInformation = new EmployeeInformation();
            employeeInformation.ChooseOperation(Choice);


        }

    }
}






/*bool birthdate = DateTime.TryParseExact("dob","DD-MM-YYYY",CultureInfo.InvariantCulture,DateTimeStyles.None,out dob);
if(birthdate != true)
{
    Console.WriteLine("Invalid date!");
}
else
{
    Console.WriteLine("Date of birth: " + dob.ToShortDateString());  
}
bool joindate = DateTime.TryParseExact("doj","DD-MM-YYYY",CultureInfo.InvariantCulture,DateTimeStyles.None,out doj);
if(joindate != true)
{
 Console.WriteLine("Invalid date!");
}
else
{
           Console.WriteLine("Date of join: " + doj.ToShortDateString());  
}*/




//nothing should be in there in main method only callable statement;
//error message should be perfect
//1)naming 2)comments 3)crud operation 4)validation 5)
// class name should be noun and method name should be verb;
// empid- ace 4digit; //ace2345
// mobile-10digit;
// dob,doj- 18-60,based on dob validate doj;
//using System.Globalization;
//using System.Text.RegularExpressions;
//System.Console.WriteLine(DateOfBirth);
//System.Console.WriteLine(DateOfJoin);
 