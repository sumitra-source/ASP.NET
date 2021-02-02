using ERPractical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical.Controllers
{
    public class MarkController : Controller
    {
        private ERTutorialDB context;
        public MarkController(ERTutorialDB _context)
        {
            context = _context;
        }

        public IActionResult Deletes(int markId)
        {
            MarkModel mark = context.Marks.Where(x => x.MarkId == markId).Select(x => new MarkModel()
            {
                MarkId = x.MarkId,
                StudentId = x.StudentId,

                SubjectId = x.SubjectId,
                Obtainedmark = x.Obtainedmark



            }).FirstOrDefault();
            return View(mark);
        }
        [HttpPost]
        public IActionResult Deletes(MarkModel mark)
        {
            Mark markRow = new Mark();
            markRow = context.Marks.Where(x => x.MarkId == mark.MarkId).FirstOrDefault();

            context.Marks.Remove(markRow);
            context.SaveChanges();
            return RedirectToAction("Marks");
        }
        public IActionResult Creates()
        {
            var Students = context.Students.Select(student => new StudentModel
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Batch = student.Batch,
                ContactNumber = student.ContactNumber
            }).ToList();
            ViewBag.Students = new SelectList(Students, "StudentId", "StudentName");

            var Subjects = context.Subjects.Select(x => new SubjectModel
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName
            }).ToList();
            ViewBag.Subjects = new SelectList(Subjects, "SubjectId", "SubjectName");
            return View(new MarkModel());
        }

        [HttpPost]
        public IActionResult Creates(MarkModel mark)
        {
            Mark markRow = new Mark();
            markRow.MarkId = mark.MarkId;
            markRow.StudentId = mark.StudentId;

            markRow.Obtainedmark = mark.Obtainedmark;

            markRow.SubjectId = mark.SubjectId;


            context.Marks.Add(markRow);
            context.SaveChanges();
            return RedirectToAction("Marks");
        }
        public IActionResult Marks_Details(int markId)
        {

            MarkModel mark = context.Marks.Where(x => x.MarkId == markId).Select(x => new MarkModel()
            {
                MarkId = x.MarkId,
                SubjectId = x.SubjectId,
                Obtainedmark = x.Obtainedmark,
                StudentId = x.StudentId


            }).FirstOrDefault();

            return View(mark);
        }
        public IActionResult Edits(int markId)
        {

            var Students = context.Students.Select(student => new StudentModel
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Batch = student.Batch,
                ContactNumber = student.ContactNumber
            }).ToList();
            ViewBag.Students = new SelectList(Students, "StudentId", "StudentName");

            var Subjects = context.Subjects.Select(x => new SubjectModel
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName
            }).ToList();
            ViewBag.Subjects = new SelectList(Subjects, "SubjectId", "SubjectName");

            MarkModel mark = context.Marks.Where(x => x.MarkId == markId).Select(x => new MarkModel()
            {
                MarkId = x.MarkId,
                StudentId = x.StudentId,

                Obtainedmark = x.Obtainedmark,

                SubjectId = x.SubjectId,


            }).FirstOrDefault();
            return View(mark);
        }
        [HttpPost]
        public IActionResult Edits(MarkModel mark)
        {
            Mark markRow = new Mark();
            markRow.StudentId = mark.StudentId;
            markRow.MarkId = mark.MarkId;

            markRow.SubjectId = mark.SubjectId;
            markRow.Obtainedmark = mark.Obtainedmark;



            context.Marks.Attach(markRow);
            context.Entry(markRow).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Marks");
        }
        public IActionResult Marks()

        {
            List<MarkModel> marks = (from M in context.Marks
                                     join S in context.Students on M.StudentId equals S.StudentId
                                     join Su in context.Subjects on M.SubjectId equals Su.SubjectId
                                     select new MarkModel()
                                     {
                                         MarkId = M.MarkId,
                                         StudentId = M.StudentId,
                                         StudentName = S.StudentName,
                                         SubjectName = Su.SubjectName,

                                         Obtainedmark = M.Obtainedmark,

                                         SubjectId = M.SubjectId


                                     }).ToList();
            return View(marks);

        }
        public IActionResult StudentMarks(int studentId)
        {
            List<MarksModel> marks = context.MarksModel.FromSqlRaw("SpGetStudentMarks"+ studentId.ToString()).ToList();
            return View(marks);

        }
    }
}