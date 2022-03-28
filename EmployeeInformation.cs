
using System;
using System.Collections.Generic;

namespace Employee
{
    public class EmployeeInformation
    {
        public void AddEmployeeDetails()
        {
            employeeList.Add(new EmployeeInformation()
            {
                EmployeeId = GetEmployeeId(),
                EmployeeName = GetEmployeeName(),
                EmployeeEmail = GetEmployeeMailId(),
                EmployeePhoneNumber = GetEmployeePhoneNumber()
        });
           

            GetEmployeeDateOfBirth();
            string DOB = DateOfBirth.ToShortDateString();
            //employeeList.Add(DOB);

            GetEmployeeDateOfJoin();
            string DOJ = DateOfJoin.ToShortDateString();
            //    employeeList.Add(DOJ);

            //employeeList.Add(new EmployeeInformation { EmployeeName = EmployeeName, EmployeeId = EmployeeId, EmployeeEmail = EmployeeEmail, EmployeePhoneNumber = EmployeePhoneNumber, DateOfBirth = DateOfBirth, DateOfJoin = DateOfBirth });
            System.Console.WriteLine("Details are successfully added!");
            /*foreach(string employee in employeeList)
            {
                Console.WriteLine(string.Format("Details are: ({0}).",string.Join(", ",employeeList)));
            }*/
            //EmployeeList();
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee);
            }


        }
        /*public void EmployeeList()
        {
            Console.WriteLine(string.Format("Details are: {0}.",string.Join(", ",employeeList)));
        }*/

        public string GetEmployeeDateOfJoin()
        {
            Console.WriteLine("Enter the date of join in the format dd-mm-yy:");

            try
            {
                DateOfJoin = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("String is not allowed...Enter details in the date format dd-mm-yy");
                GetEmployeeDateOfJoin();
            }

            if ((DateOfJoin.Year - DateOfBirth.Year) < 18)
            {
                Console.WriteLine("Age is Too small..Age must be atleast 18!");
                GetEmployeeDateOfJoin();
            }

            if ((DateOfJoin.Year - DateOfBirth.Year) > 60)
            {
                Console.WriteLine("Age is too high...Age must be less than 60");
                GetEmployeeDateOfJoin();
            }
            return DateOfJoin.ToString();


        }

        public string GetEmployeeDateOfBirth()
        {
            Console.WriteLine("Enter the date of birth in the format dd-mm-yy:");
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("String is not allowed...Enter details in the date format dd-mm-yy");
                GetEmployeeDateOfBirth();
            }

            if ((DateTime.Now.Year - DateOfBirth.Year) > 70)
            {
                Console.WriteLine("Age is too high... Age should be less than 60!");
                GetEmployeeDateOfBirth();
            }
            else if ((DateTime.Now.Year - DateOfBirth.Year) < 18)
            {
                Console.WriteLine("Age is too low... Age should be greate than 18 !");
                GetEmployeeDateOfBirth();
            }
            return DateOfBirth.ToString();

        }

        public string GetEmployeeMailId()
        {
            Console.WriteLine("Enter the Employee Email Id:");
            EmployeeEmail = Console.ReadLine();
            bool validEmail = validation.EmailValidation(EmployeeEmail);
            if (validEmail != true)
            {
                Console.WriteLine("Email must be a valid email in the format name@aspiresys.com!");
                GetEmployeeMailId();
            }
            return EmployeeEmail;

        }

        public string GetEmployeePhoneNumber()
        {
            Console.WriteLine("Enter the Employee Phone Number:");
            EmployeePhoneNumber = Console.ReadLine();
            bool validPhoneNumber = validation.NumberValidation(EmployeePhoneNumber);
            if (validPhoneNumber != true)
            {
                Console.WriteLine(" Phone number should starts with 6,7,8, or 9!");
                GetEmployeePhoneNumber();
            }
            return EmployeePhoneNumber;

        }

        public string GetEmployeeId()
        {
            Console.WriteLine("Enter the Employee Id:");
            EmployeeId = Console.ReadLine();
            bool validId = validation.IdValidation(EmployeeId);
            if (validId != true || EmployeeId == "ACE0000")
            {
                Console.WriteLine("Id should contains ACE followed by 4 digits!");
                GetEmployeeId();
            }
            return EmployeeId;



        }


        public string GetEmployeeName()
        {

            Console.WriteLine("Enter the Employee Name:");
            EmployeeName = Console.ReadLine();
            bool validName = validation.NameValidation(EmployeeName);
            if (validName != true)
            {
                Console.WriteLine("Name is not valid please enter a valid name!");

                GetEmployeeName();
            }
            return EmployeeName;

        }

        public void ChooseOperation(int TypeOfOperation)
        {
            switch (TypeOfOperation)
            {
                case 1:
                    //get the number of employees we need to add
                    Console.WriteLine("How many employees do you want to add?");
                    int NumberOfEmployees = Convert.ToInt32(Console.ReadLine());
                    if(NumberOfEmployees > 10)
                    {
                        System.Console.WriteLine("Please choose number less than or equal to 10!!!");
                        ChooseOperation(TypeOfOperation);
                    }
                    for (int NumOfEmployees = 1; NumOfEmployees <= NumberOfEmployees; NumOfEmployees++)
                    {
                        employeeCrudOperation.InsertDetails();
                        // employeeCrudOperation.connection();
                    }
                   
                    EmployeeApplicationForm.EmployeeApp();
                    //Validate(NumberOfEmployees);
                    break;
                case 2:
                    //employeeCrudoperation.ReadDetails();
                    Console.WriteLine("Enter the Employee Id to see Details of Employee.\n");
                    employeeCrudOperation.DisplayTable();
                    
                    EmployeeApplicationForm.EmployeeApp();
                    break;
                case 3:
                    //employeeCrudoperation.UpdateDetails();
                    Console.WriteLine("Enter the employee id to update the employee details...\n");
                    employeeCrudOperation.UpdateDetails();
                    EmployeeApplicationForm.EmployeeApp();
                    break;
                case 4:
                   // employeeCrudoperation.DisplayDetails();
                    Console.WriteLine("Enter the employee id to display the respective employee details...\n");
                    employeeCrudOperation.DisplayDetails();
                    EmployeeApplicationForm.EmployeeApp();
                    break;
                case 5:
                   // employeeCrudoperation.DeleteDetails();
                    Console.WriteLine("Enter the employee id to delete the employee details..\n");
                    //Console.WriteLine("Delete employee details");
                    employeeCrudOperation.DeleteDetails();
                    EmployeeApplicationForm.EmployeeApp();
                    break;
                case 6:
                    Console.WriteLine("press Enter to Exit!!!");
                    break;
                default:
                    Console.WriteLine("Enter a valid choice from 1 to 6");
                    EmployeeApplicationForm.EmployeeApp();
                    break;
            }

            //Ask the details of employees from input from the user

        }
        
        string? EmployeeId, EmployeeName, EmployeeEmail, EmployeePhoneNumber;
        DateTime DateOfBirth, DateOfJoin;
        Validation validation = new Validation();
        EmployeeCrudOperation employeeCrudOperation = new EmployeeCrudOperation();

        List<EmployeeInformation> employeeList = new List<EmployeeInformation>();
    }
}
