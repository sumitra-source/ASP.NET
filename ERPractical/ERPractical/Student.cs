using DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical
{
    [Table("Student", Schema = "dbo")]
    public partial class Student
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public string Address { get; set; }
        public string Batch { get; set; }
        public string ContactNumber { get; set; }
    }

    [Table("Mark", Schema = "dbo")]
    public partial class Mark
    {

        public int MarkId { get; set; }
        public int SubjectId { get; set; }

        public decimal Obtainedmark { get; set; }
        public int StudentId { get; set; }

    }
    [Table("Subject", Schema = "dbo")]
    public partial class Subject
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }

}
