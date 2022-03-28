using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Employee
{
    public class EmployeeCrudOperation
    {
        string cs = "data source = .; database = master; integrated security = SSPI";

        public void InsertDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTable(EmployeeId,EmployeeName,EmployeeMail,EmployeePhonenumber,EmployeeDateofbirth,EmployeeDatofjoin) values(GetEmployeeId(),GetEmployeeName(),GetEmployeeMailId()," +
                    "GetEmployeePhoneNumber(),GetEmployeeDateOfBirth(),GetEmployeeDateOfJoin())", conn);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Record Inserted Successfully");

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void DisplayTable()
        {
            try
            {
                // Creating Connection
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand("select * from EmployeeTable", conn);

                    // Executing the SQL query  
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine(sqlDataReader["EmployeeID"] + "  " + sqlDataReader["EmployeeName"] + "  " + sqlDataReader["EmployeeEmail"] + "  " + sqlDataReader["EmployeePhoneNumber"] + "  " + sqlDataReader["DateOFBirth"] + "  " + sqlDataReader["DateOfJoining"]);
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("OOPS, something went wrong." + exception);
            }

        }

        string? ColumnName, NewValue, Updatecolumn;
        string ID = "EmployeeID";

        public void UpdateDetails()
        {
            try
            {
                //Condition = employeeDetails.AddEmployeeID();
                Console.WriteLine("\nEnter the column to update:\n" +
                                    "\n1[EmployeeID]\n2[EmployeeName]\n3[EmployeeEmail]\n4[EmployeePhoneNumber]\n5[DateOFBirth]\n6[DateOfJoining]"
                                    );

                int column = Convert.ToInt32(Console.ReadLine());
                ChooseColumnName(column);
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE EmployeeTable SET [" + ColumnName + "]='" + NewValue + "'WHERE [" + ID + "]='" + Updatecolumn + "';", conn);


                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Record updated Successfully\n");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("OOPs, something went wrong." + exception);
            }
            void ChooseColumnName(int Column)
            {
                switch (Column)
                {
                    case 1:
                        {
                            Updatecolumn = employeeInformation.GetEmployeeId();
                            ColumnName = "EmployeeName";
                            NewValue = employeeInformation.GetEmployeeName();
                            break;
                        }
                    case 2:
                        {
                            Updatecolumn = employeeInformation.GetEmployeeId();
                            ColumnName = "EmployeeEmail";
                            NewValue = employeeInformation.GetEmployeeMailId();
                            break;
                        }
                    case 3:
                        {
                            Updatecolumn = employeeInformation.GetEmployeeId();
                            ColumnName = "EmployeePhoneNumber";
                            NewValue = employeeInformation.GetEmployeePhoneNumber();
                            break;
                        }
                    case 4:
                        {
                            Updatecolumn = employeeInformation.GetEmployeeId();
                            ColumnName = "DateOfBirth";
                            NewValue = employeeInformation.GetEmployeeDateOfBirth();
                            break;
                        }
                    case 5:
                        {
                            Updatecolumn = employeeInformation.GetEmployeeId();
                            ColumnName = "DateOfJoining";
                            NewValue = employeeInformation.GetEmployeeDateOfJoin();
                            break;
                        }
                    case 6:
                        {
                            Updatecolumn = employeeInformation.GetEmployeeId();
                            ColumnName = "EmployeeID";
                            NewValue = employeeInformation.GetEmployeeId();
                            break;
                        }
                    default:
                        Console.WriteLine("Invaild input.Enter Numbers from 1 to 6 only");
                        break;
                }
            }
        }

        public void DisplayDetails()
        {
            try
            {
                string display = employeeInformation.GetEmployeeId();

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand sqlCommand = new SqlCommand("select * from EmployeeTable where EmployeeID='" + display + "';", conn);

                    conn.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine(sqlDataReader["EmployeeID"] + "  " + sqlDataReader["EmployeeName"] + "  " + sqlDataReader["EmployeeEmail"] + "  " + sqlDataReader["EmployeePhoneNumber"] + "  " + sqlDataReader["DateOFBirth"] + "  " + sqlDataReader["DateOfJoining"]);
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("OOPs, something went wrong." + exception);
            }
        }
        public void DeleteDetails()
        {
            try
            {
                Console.WriteLine("Enter EmployeeID to delete the specific Employee:");
                string delete = employeeInformation.GetEmployeeId();
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();


                    SqlCommand sqlCommand = new SqlCommand("Delete From EmployeeTable where EmployeeId='" + delete + "';", conn);


                    sqlCommand.ExecuteNonQuery();

                    Console.WriteLine("Record with EmployeeID  " + delete + " is Deleted Successfully\n");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("OOPS, something went wrong." + exception);
            }


        }
        EmployeeInformation employeeInformation = new EmployeeInformation();

    }
}