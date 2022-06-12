using EduAfri.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Controllers
{
    public class ClassController : Controller
    {
        private readonly AppDbContext _context;

        public ClassController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allClasses = _context.Classes.ToList();
            return View(allClasses);
        }

        /* public async Task<IActionResult> Index()
         {
             var allClass = await _context.Classes.Include(n => n.Subject).OrderBy(n => n.Id).ToListAsync();
             return View(allClass);
         }*/

        [HttpGet("{ClassId}")]
        public async Task<IActionResult> SelectSubject(int ClassId)
        {
            var selectClass = _context.Classes.Where(n => n.Id == ClassId).FirstOrDefault();
            //check for "ClassId" match
            var allSubjects = await _context.Subjects.Where(n => n.ClassId == ClassId ).ToListAsync();
            if (allSubjects == null) return View("NotFound");

            foreach (var item in allSubjects)
            {
                item.Class = selectClass;
            }

            return View(allSubjects);

        }

       
    }
}
