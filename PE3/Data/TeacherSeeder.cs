using Microsoft.EntityFrameworkCore;
using PE3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Data
{
    public class TeacherSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                (new Teacher()    
                {
                    Id = 1,
                    FirstName = "Dirk",
                    LastName = "Vandenbroucke",
                    Login = "dvandenbroucke",
                    Password = "teacher",
                }),
                (new Teacher()    
                {
                    Id = 2,
                    FirstName = "Evan",
                    LastName = "Dierickx",
                    Login = "edierickx",
                    Password = "teacher",
                }),
                (new Teacher()    
                {
                    Id = 3,
                    FirstName = "Sam",
                    LastName = "Verkeyen",
                    Login = "sverkeyen",
                    Password = "teacher",
                }),
                (new Teacher()    
                {
                    Id = 4,
                    FirstName = "Erika",
                    LastName = "Berends",
                    Login = "eberends",
                    Password = "teacher",
                }),
                (new Teacher()    
                {
                    Id = 5,
                    FirstName = "Sarah",
                    LastName = "Cramers",
                    Login = "scramers",
                    Password = "teacher",
                })
                
                
                
                );
        }
    }
}
