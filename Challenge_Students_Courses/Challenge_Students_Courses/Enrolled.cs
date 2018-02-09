using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Students_Courses
{
	public class Enrolled
	{
		public Student Student { get; set; }
		public Course Course { get; set; }
		public int Grade { get; set; }
	}
}