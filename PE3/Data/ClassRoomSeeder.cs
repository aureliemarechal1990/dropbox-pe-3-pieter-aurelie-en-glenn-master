using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PE3.Entities;

namespace PE3.Data
{
	public class ClassRoomSeeder
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ClassRoom>().HasData(
				new ClassRoom {Id = 1, TeacherId = 1, AmountOfPupils = 0},
				new ClassRoom {Id = 2, TeacherId = 2, AmountOfPupils = 0},
				new ClassRoom {Id = 3, TeacherId = 3, AmountOfPupils = 10}
			);
		}
	}
}
