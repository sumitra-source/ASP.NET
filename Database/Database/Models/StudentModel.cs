using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public int RollNo { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
    public class ClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassTeacher { get; set; }
    }
    public class SubjectModel
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }
}
