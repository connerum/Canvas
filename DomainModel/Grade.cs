namespace DomainModel
{
    public class Grade
    {
        public int GradeID { get; set; }
        public float Score { get; set; }
        public string Feedback { get; set; }

        public void ViewScore() { /* Implementation */ }
        public void ViewFeedback() { /* Implementation */ }
    }
}
