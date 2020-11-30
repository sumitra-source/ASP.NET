using ASP.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ClassIndex()
        {
            List<ClassModel> classes = new List<ClassModel>();
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-6P6C4JH;database=StudentManagement;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select *from Student", sqlConnection);//it is a SQL command to execute in database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);//it is a buffer to hold data from database
            DataTable dataTable = new DataTable();//it is a data type like integer
            sqlDataAdapter.Fill(dataTable);//fill the dataTable from the buffer
            return View(dataTable);
        }

    }
}
