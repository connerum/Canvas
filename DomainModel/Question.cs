using System.Collections.Generic;

namespace DomainModel
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public List<string> AnswerOptions { get; set; }
        public string CorrectAnswer { get; set; }

        public void SelectAnswer(string answer) { /* Implementation */ }
    }
}
