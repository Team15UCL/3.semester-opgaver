using Microsoft.EntityFrameworkCore;
using Uge7Opgave2._01.Models;

namespace Uge7Opgave2._01.Data;

public static class SeedData
{
	public static void Initialize(IServiceProvider serviceProvider)
	{
		using (var context = new StudentContext(
			       serviceProvider.GetRequiredService<DbContextOptions<StudentContext>>()))
		{
			if (context.Student.Any())
			{
				return;
			}

			context.AddRange(
				new Student("Aske", "Lysgaard", 15, 25),
				new Student("Mark", "Staf", 15, 30),
				new Student("Ida", "Thomsen", 15, 49),
				new Student("Sebastian", "Hundebøl", 15, 25)
				);

			context.SaveChanges();
		}
	}
}
