using EduAfri.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string MediaUrl { get; set; }
        public MediaType MediaType { get; set; }


        //Relatioship with Subject
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subjects { get; set; }
        
    } 
}
