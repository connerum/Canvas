using System.Collections.Generic;

namespace DomainModel
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Course> Courses { get; set; }

        public void EnrollInCourse(Course course) { /* Implementation */ }
        public void ViewGrades() { /* Implementation */ }
    }
}
