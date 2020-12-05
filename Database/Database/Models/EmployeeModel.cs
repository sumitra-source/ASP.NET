using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class EmployeeModel
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_address { get; set; }
    }
    public class SalaryModel
    {
        public int emp_id { get; set; }
        public string sal_id { get; set; }
        public string sal { get; set; }
    }
}
   
