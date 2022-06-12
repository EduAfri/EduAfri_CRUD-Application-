using EduAfri.Data;
using EduAfri.Data.Services;
using EduAfri.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }
         
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET: Student/Add
         public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("FName,LName,Email,Address,Gender")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        //Get:student/details/1
        public async Task<IActionResult> Details (int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);

            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

   

        //GET: Student/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);

            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [ Bind("StudentId, FName,LName,Email,Address,Gender")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.UpdateAsync(id, student);
            return RedirectToAction(nameof(Index));
        }


        //GET: Student/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);

            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
