using EduAfri.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Models
{
    public class Tutor:IEntityBase
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Biography { get; set; }
        public string Gender { get; set; }
        public string AreaOfSpecialty { get; set; }
        public DateTime RegDate { get; set; }
        public string Address { get; set; }

        //Relationships

        public List<Subject> Subjects { get; set; }
    }
}
