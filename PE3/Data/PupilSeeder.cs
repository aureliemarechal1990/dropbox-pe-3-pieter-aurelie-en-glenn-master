using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PE3.Entities;


namespace PE3.Data
{
    public class PupilSeeder
    {
         
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pupil>().HasData(
            (new Pupil()    
            {
                Id = 1,
                Birthdate = new DateTime(2010, 01, 15),
                FirstName = "Jonas",
                LastName = "Wouters",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 2,
                Birthdate = new DateTime(2010, 04, 18),
                FirstName = "Henk",
                LastName = "Verweer",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 3,
                Birthdate = new DateTime(2009, 12, 22),
                FirstName = "Emma",
                LastName = "Verdonck",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 4,
                Birthdate = new DateTime(2010, 05, 09),
                FirstName = "Chloe",
                LastName = "Pashalis",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 5,
                Birthdate = new DateTime(2010, 04, 11),
                FirstName = "Amelia",
                LastName = "Armstrong",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 6,
                Birthdate = new DateTime(2009, 10, 05),
                FirstName = "Nick",
                LastName = "Vermeersch",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 7,
                Birthdate = new DateTime(2010, 08, 05),
                FirstName = "John",
                LastName = "Crombez",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {   
                Id = 8,
                Birthdate = new DateTime(2010, 07, 11),
                FirstName = "Erik",
                LastName = "Braet",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 9,
                Birthdate = new DateTime(2010, 04, 02),
                FirstName = "Lily",
                LastName = "Peeters",
                CurrentLevel = 1,
                Results = null
            }),
            (new Pupil
            {
                Id = 10,
                Birthdate = new DateTime(2010, 3, 31),
                FirstName = "Pieter-Paul",
                LastName = "Pruim",
                CurrentLevel = 1,
                Results = null
            }));   
       
        }
   

    }
}
