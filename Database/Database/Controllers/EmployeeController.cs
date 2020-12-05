using Database.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace Database.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult ClsIndex()
        {
            string datasource = @"Data Source=DESKTOP-6P6C4JH;
                      database=EmployeeManagement;
                          Integrated Security=True;
                        
                          User Instance=True";
            List<EmployeeModel> employees = new List<EmployeeModel>();
           // SqlConnection sqlConnection = @"Data Source=DESKTOP-6P6C4JH;database=EmployeeManagement;
//Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(datasource);
   
      
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select *from Empdetail", sqlConnection);//it is a SQL command to execute in database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);//it is a buffer to hold data from database
            DataTable dataTable = new DataTable();//it is a data type like integer
            sqlDataAdapter.Fill(dataTable);//fill the dataTable from the buffer
            return View(dataTable);
        }
    }
}