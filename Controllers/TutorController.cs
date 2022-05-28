using EduAfri.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Controllers
{
    public class TutorController : Controller
    {
        private readonly AppDbContext _context;

        public TutorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Tutors.ToList();
            return View(data);
        }
    }
}
