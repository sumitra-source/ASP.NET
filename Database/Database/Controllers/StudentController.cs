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
            // string datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shres\Desktop\ASP.NET\Database\DaL\EmpManagement.mdf;Integrated Security=True;
            //  "
            // ;
            // string datasource = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\shres\Desktop\ASP.NET\Database\DaL\StudentManagement.mdf; Integrated Security = True;
            //  ";
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-6P6C4JH;database=Employeemanagement;Integrated Security=True");
            List<ClassModel> classes = new List<ClassModel>();
            // SqlConnection sqlConnection = new SqlConnection(datasource);
            //SqlConnection sqlConnection = new SqlConnection("Data Source=Ramesh-Pc;database=SchoolBasu;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Empdetail", sqlConnection);//it is a sql command to execute in database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // its a buffer to hold data from database
            DataTable dataTable = new DataTable(); //its is data type, like integer
            sqlDataAdapter.Fill(dataTable); //fill the datatable from the buffer
            sqlConnection.Close();
            return View(dataTable);
        }
   
      public IActionResult AddUpdateClass(int? classId)
        {
            ClassModel classModel = new ClassModel();

            return View(classModel);
        }

        [HttpPost]
        public IActionResult AddUpdateClass(ClassModel classModel)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-6P6C4JH;database=Employeemanagement;Integrated Security=True"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into Empdetail(emp_name,emp_id,emp_address) values ('" + classModel.ClassName + "','" + classModel.ClassId + "','" + classModel.ClassTeacher +"' )", sqlConnection);//it is a sql command to execute in database
                int affectedRows = sqlCommand.ExecuteNonQuery();
                //sqlConnection.Close();
                return RedirectToAction("ClassIndex");
            }
        }


       // public IActionResult Students()
       // {
            //List<BMCStudentModel> students = context.Students.Select(x => new BMCStudentModel()
            //{
            //    StudentId=x.StudentId,
            //    StudentName = x.StudentName,
            //    Address=x.Address,
            //    Batch=x.Batch,
            //    ContactNumber=x.ContactNumber
            //}
            //).ToList();

         //   List<Student> students = context.Students.ToList();
           // return View(students);
        }
    }
