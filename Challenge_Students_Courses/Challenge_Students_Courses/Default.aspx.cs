using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Students_Courses
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void assignment1Button_Click(object sender, EventArgs e)
		{
			List<Course> courses = new List<Course>()
			{	new Course { CourseId = 101, Name = "Calculus", Students = new List<Student> (){
					new Student() { StudentId = 2, Name = "John"},
					new Student() { StudentId = 5, Name = "Isabel"} } },
				new Course { CourseId = 202, Name = "Linear Algebra", Students = new List<Student> (){
					new Student() { StudentId = 3, Name = "Allie"},
					new Student() { StudentId = 6, Name = "Kim"}  } },
				new Course { CourseId = 340, Name = "Genetics", Students = new List<Student> (){
					new Student() { StudentId = 4, Name = "Jill"},
					new Student() { StudentId = 1, Name = "Joe"} } }
			};

			foreach (var course in courses)
			{
				resultLabel.Text += String.Format("<br />Course Title: {0} - {1}", course.CourseId, course.Name);
					foreach (var student in course.Students)
				{
					resultLabel.Text += String.Format("<br /> Student: {0} - {1}", student.StudentId, student.Name);
				}
			}
		}

		protected void assignment2Button_Click(object sender, EventArgs e)
		{
			Course course1 = new Course() { CourseId = 100, Name = "Ecology" };
			Course course2 = new Course() { CourseId = 101, Name = "Psychology" };
			Course course3 = new Course() { CourseId = 102, Name = "Chemistry" };
			Course course4 = new Course() { CourseId = 103, Name = "English" };

			Dictionary<int, Student> students = new Dictionary<int, Student>()
			{
				{1, new Student { StudentId = 10, Name = "Rand", Courses = new List<Course> {course2, course3} } },
				{2, new Student { StudentId = 11, Name = "Rita", Courses = new List<Course> {course3, course4} } },
				{3, new Student { StudentId = 12, Name = "Rachel", Courses = new List<Course> {course2, course1} } }
			};

			foreach (var student in students)
			{
				resultLabel.Text += String.Format("<br /> Student: {0} - StudentId: {1}", student.Value.Name, student.Value.StudentId );
				foreach (var course in student.Value.Courses)
				{
					resultLabel.Text += String.Format("<br /> Course: {0} {1}", course.Name, course.CourseId);
				}
			}
		}

		protected void assignment3Button_Click(object sender, EventArgs e)
		{
			Student student = new Student();
			student.Name = "Fibonacci";
			student.StudentId = 100;
			student.Enrolled = new List<Enrolled>() {
				new Enrolled { Course = new Course { CourseId = 2, Name = "Golf" , Grade = 82} },
				new Enrolled { Course = new Course { CourseId =3, Name = "Yoga", Grade =  90} }
			};
			resultLabel.Text += String.Format("<br />Student: {0} StudentId: {1}", student.Name, student.StudentId);
			foreach (var enrolled in student.Enrolled)
			{
				resultLabel.Text += String.Format("<br />Enrolled in: {0} - Grade: {1}", enrolled.Course.Name, enrolled.Course.Grade);
			};
		}
	}
}