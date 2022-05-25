using EduAfri.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduAfri.Data
{
    public class AppDbContext : DbContext
    {
        //Define a public constructor for the AppDbContext and parse to the base class using the Base keyword.
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Define the  joining table for many - many relationship here
            modelBuilder.Entity<Subj_Stud>().HasKey(ss => new
            {
                ss.SubjectId,
                ss.StudentId
            });

            //Define Subj_Studs to be the joining table in C# side for subject
            modelBuilder.Entity<Subj_Stud>().HasOne(s => s.Subject).WithMany(ss => ss.Subj_Studs).HasForeignKey(s => s.SubjectId);

            //Define Subj_Studs to be the joining table in C# side for subject
            modelBuilder.Entity<Subj_Stud>().HasOne(s => s.Student).WithMany(ss => ss.Subj_Studs).HasForeignKey(s => s.StudentId);
            base.OnModelCreating(modelBuilder);
        }

        // define table name for each model
        public DbSet<Class> Classes { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Subj_Stud> Subj_Studs { get; set; }
        public DbSet<Student> Students { get; set; }




    }
}
