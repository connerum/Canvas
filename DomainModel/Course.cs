using System.Collections.Generic;

namespace DomainModel
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Instructor Instructor { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Discussion> Discussions { get; set; }
        public List<Quiz> Quizzes { get; set; }

        public void AccessCourseMaterial() { /* Implementation */ }
        public void ParticipateInDiscussion(Discussion discussion) { /* Implementation */ }
        public void SubmitAssignment(Assignment assignment) { /* Implementation */ }
        public void TakeQuiz(Quiz quiz) { /* Implementation */ }
    }
}
