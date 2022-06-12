using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Models
{
    public class Subj_Stud
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }//establish join

        public int StudentId { get; set; }
        public Student Student { get; set; } // establish join
        


        //relationship 




    }
}
