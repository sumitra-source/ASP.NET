using ERPractical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical.Controllers
{
    public class SubjectController : Controller
    {
        private ERPracticalDB context;
        public SubjectController(ERPracticalDB _context)
        {
            context = _context;
        }
        public IActionResult Edit(int subjectId)
        {
            SubjectModel subject = context.Subjects.Where(x => x.SubjectId == subjectId).Select(x => new SubjectModel()
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName

               


            }).FirstOrDefault();
            return View(subject);
        }
        [HttpPost]
        public IActionResult Edit(SubjectModel subject)
        {
            Subject subjectRow = new Subject();
            subjectRow.SubjectId = subject.SubjectId;
            subjectRow.SubjectName = subject.SubjectName;

         
            context.Subjects.Attach(subjectRow);
            context.Entry(subjectRow).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Subjects");
        }
        public IActionResult Delete(int subjectId)
        {
            SubjectModel subjects = context.Subjects.Where(x => x.SubjectId == subjectId).Select(x => new SubjectModel()
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName



            }).FirstOrDefault();
            return View(subjects);
        }
        [HttpPost]
        public IActionResult Delete(SubjectModel subject)
        {
            Subject subjectRow = new Subject();
            subjectRow = context.Subjects.Where(x => x.SubjectId == subject.SubjectId).FirstOrDefault();

            context.Subjects.Remove(subjectRow);
            context.SaveChanges();
            return RedirectToAction("Subjects");
        }
        public IActionResult Details(int subjectId)
        {
            SubjectModel subject = context.Subjects.Where(x => x.SubjectId == subjectId).Select(x => new SubjectModel()
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName,
                

            }).FirstOrDefault();

            return View(subject);
        }

        public IActionResult Create()
        {
            return View(new SubjectModel());
        }
        [HttpPost]
        public IActionResult Create(SubjectModel subject)
        {
            Subject subjectRow = new Subject();
            subjectRow.SubjectId = subject.SubjectId;
            subjectRow.SubjectName = subject.SubjectName;
            context.Add(subjectRow);
            //  context.Entry(studentRow).State = EntityState.Added;
            context.SaveChanges();
            return RedirectToAction("subjects");
        }
        public IActionResult Subjects()
        {
            List<SubjectModel> subjects = context.Subjects.Select(subject => new SubjectModel()
            {
                SubjectId = subject.SubjectId,
                SubjectName = subject.SubjectName,

              
            }
            )
                .ToList();
            return View(subjects);
          
        }
    }
}
