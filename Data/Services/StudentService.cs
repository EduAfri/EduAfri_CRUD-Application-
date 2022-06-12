using EduAfri.Data.Base;
using EduAfri.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Data.Services
{
    public class StudentService : EntityBaseRepository<Student>, IStudentService
    {
      
        public StudentService(AppDbContext context) : base(context) 
        { 
        }
    }   
}
