using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Students_Courses
{
	public class Student
	{
		public int StudentId { get; set; }
		public string Name { get; set; }
		public List<Course> Courses { get; set; }
		public List<Enrolled> Enrolled { get; set; }
	}
}