using EduAfri.Data;
using EduAfri.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Controllers
{
    public class SubjectController : Controller
    {
        private readonly AppDbContext _context;

        public SubjectController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var allClass = _context.Classes.ToList();
       
            
            var allSubjects = await _context.Subjects.ToListAsync(); 
            if (allSubjects == null) return View("NotFound");

            //Get Class info in subject

            foreach ( var item in allSubjects)
            {
                item.Class = allClass.Where(x => x.Id == item.Id).FirstOrDefault();
            }
            return View(allSubjects);
        }

     
        public async Task<IActionResult> ClassRoom()
         {
            var allClass = _context.Classes.ToList();

            var allSubjects = await _context.Subjects.ToListAsync();
            if (allSubjects == null) return View("NotFound");

            //Get Class info in subject

            foreach (var item in allSubjects)
            {
                  item.Class = allClass.Where(x => x.Id == item.ClassId).FirstOrDefault();
              }

             return View(allSubjects);



         }

        public async Task<IActionResult> Content()
        {

            var allClass = _context.Classes.ToList();


            var allSubjects = await _context.Subjects.ToListAsync();
            if (allSubjects == null) return View("NotFound");

            //Get Class info in subject

            foreach (var item in allSubjects)
            {
                item.Class = allClass.Where(x => x.Id == item.Id).FirstOrDefault();
            }



            return View(allSubjects);



        }
    }
}
