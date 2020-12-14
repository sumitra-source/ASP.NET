using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        [DisplayName("Full Name")]
        public string StudentName { get; set; }

        public string Address { get; set; }
        public string Batch { get; set; }
        public string ContactNumber { get; set; }
    }
    public class MarkModel
    {

        public int MarkId { get; set; }
        public int SubjectId { get; set; }
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        [DisplayName("Subject Name")]
        public string SubjectName { get; set; }

        public decimal Obtainedmark { get; set; }
        public int StudentId { get; set; }

    }
    public class SubjectModel
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

    }
}
