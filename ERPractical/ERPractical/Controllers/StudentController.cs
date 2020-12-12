using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ERPractical.Controllers
{
    public class StudentController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ERPracticalDB context;
        public StudentController(ERPracticalDB _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult Students()
        {
            List<Student> students = context.Students.ToList();
            return View(students);
           
           


        }
    }
}
