﻿using EduAfri.Data.Base;
using EduAfri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Data.Services
{
    public class SubjectService: EntityBaseRepository<Subject>, ISubjectService
    {
        public SubjectService(AppDbContext context) : base(context)
        {
        }
    }
}
