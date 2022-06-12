using EduAfri.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ClassType ClassType { get; set; }

       
        
        //Relationships
        public List<Subject> Subjects { get; set; }

    
    }

    
}
