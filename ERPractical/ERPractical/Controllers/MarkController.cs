using ERPractical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical.Controllers
{
    public class MarkController : Controller
    {
        private ERPracticalDB context;
        public MarkController(ERPracticalDB _context)
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
               Obtainedmark=x.Obtainedmark

              

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
            MarkModel mark = context.Marks.Where(x => x.MarkId == markId).Select(x => new MarkModel()
            {
                MarkId = x.MarkId,
                StudentId = x.StudentId,

                Obtainedmark = x.Obtainedmark,

                SubjectId= x.SubjectId,
              

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
            List<MarkModel> marks = context.Marks.Select(marks => new MarkModel()
            {
                MarkId = marks.MarkId,
                StudentId = marks.StudentId,

                Obtainedmark = marks.Obtainedmark,

                SubjectId = marks.SubjectId


            }
            )
                .ToList();
            return View(marks);

        }
    }
}