using System;

namespace DomainModel
{
    public class Submission
    {
        public int SubmissionID { get; set; }
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
        public DateTime Timestamp { get; set; }
        public string Content { get; set; }

        public void UploadContent(string content) { /* Implementation */ }
        public void ViewFeedback() { /* Implementation */ }
    }
}
