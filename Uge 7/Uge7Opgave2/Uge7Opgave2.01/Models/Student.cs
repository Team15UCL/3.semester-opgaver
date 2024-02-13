using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;

namespace Uge7Opgave2._01.Models;

public class Student
{
	public Student()
	{
		
	}
	public Student(string firstName, string lastName, int teamNum, int age)
	{
		FirstName	= firstName;
		LastName	= lastName;
		TeamNum		= teamNum;
		Age			= age;
	}

	public int Id { get; set; }
	[DisplayName("First Name"), Required]
	public string FirstName { get; set; }
	[DisplayName("Last Name"), Required]
	public string LastName { get; set; }
	[DisplayName("Team Number"), Range(1, 15)]
	public int TeamNum { get; set; }
	[Range(1, 99)]
    public int Age { get; set; }
}
