using System;

namespace DomainModel
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public Submission Submission { get; set; }

        public void ViewDetails() { /* Implementation */ }
        public void UploadSubmission(Submission submission) { /* Implementation */ }
    }
}
