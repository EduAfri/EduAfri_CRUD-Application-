using EduAfri.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Started { get; set; }
        public bool Ended { get; set; }
        public Term Term { get; set; }
        public CourseCategory CourseCategory { get; set; }

        //Relationships

        public List<Subj_Stud>Subj_Studs { get; set; }

        //Relationship with Media
        public List<Media> Medias { get; set; }

        //relation with class
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        

        //Relationship with Tutor
        public int TutorId { get; set; }
        [ForeignKey("TutorId")]
        public Tutor Tutors { get; set; }



    }
}
