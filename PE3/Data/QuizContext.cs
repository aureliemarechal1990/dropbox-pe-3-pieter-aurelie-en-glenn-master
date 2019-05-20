using Microsoft.EntityFrameworkCore;
using PE3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Data
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<PupilRegistration> PupilRegistrations { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Results> Results { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            PupilSeeder.Seed(modelBuilder);
            TeacherSeeder.Seed(modelBuilder);
            ClassRoomSeeder.Seed(modelBuilder);
;			QuestionSeeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    
        
        
    }
}
