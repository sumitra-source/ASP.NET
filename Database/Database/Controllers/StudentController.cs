using Database.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ClassIndex()
        {
            // C: \Users\dell\source\repos\TestingNetNetCore\DAL\Student.mdf
            string datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shres\source\repos\Database\DaL\StudentManage.mdf;
Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True";
            List<ClassModel> classes = new List<ClassModel>();
            SqlConnection sqlConnection = new SqlConnection(datasource);
            //SqlConnection sqlConnection = new SqlConnection("Data Source=Ramesh-Pc;database=SchoolBasu;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Classes", sqlConnection);//it is a sql command to execute in database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // its a buffer to hold data from database
            DataTable dataTable = new DataTable(); //its is data type, like integer
            sqlDataAdapter.Fill(dataTable); //fill the datatable from the buffer
            sqlConnection.Close();
            return View(dataTable);
        }
    }
}
