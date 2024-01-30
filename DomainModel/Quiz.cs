using System.Collections.Generic;

namespace DomainModel
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        public Grade Grade { get; set; }

        public void StartQuiz() { /* Implementation */ }
        public void SubmitAnswers(List<Answer> answers) { /* Implementation */ }
    }
}
