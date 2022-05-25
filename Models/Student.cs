using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime RegDate { get; set; }
        public string Address { get; set; }

        //Relationships

        public List<Subj_Stud> Subj_Studs { get; set; }

    }
}
