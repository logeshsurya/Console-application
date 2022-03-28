using System;
using System.Text.RegularExpressions;
namespace Employee
{
    public class Validation
    {
        string EmpName = @"^[A-Z]{1}[a-zA-Z\s]*$";

        string EmployeeID = "^[A-Z]{3}[0-9]{4}$";
        string EmpPhoneNumber = "(^[6-9]{1}[0-9]{9}$)";
        string EmpMailID = "^[a-zA-Z0-9+_.-][a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool NameValidation(string EmpName)
        {
            return Regex.IsMatch(EmpName, this.EmpName);
        }
        public bool IdValidation(string EmpId)
        {
            return Regex.IsMatch(EmpId, EmployeeID);
        }
        public bool NumberValidation(string EmpNumber)
        {
            return Regex.IsMatch(EmpNumber, EmpPhoneNumber);
        }
        public bool EmailValidation(string EmpEmail)
        {
            return Regex.IsMatch(EmpEmail, EmpMailID);
        }
    }
}


// error msg for pno- phonenumber should begin with numbers 6,7,8 or 9;
//|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)
// crud operation-- create,read,update,delete
// , exeption handling,collections;
/*else
                    {
                        Console.WriteLine("Employee_Name: " + EmployeeName);
                    }
                    
else
                    {
                        Console.WriteLine("Employee_Id: " + EmployeeId);
                    }

else
                    {
                        Console.WriteLine("Phone number: " + EmployeePhoneNumber);
                    }

                    else
                    {
                        Console.WriteLine("Email Id:" + Email);
                    }
                    Console.WriteLine("Date of birth: " + DateOfBirth);

                    Console.WriteLine("Date of join: " + DateOfJoin);
                    */
