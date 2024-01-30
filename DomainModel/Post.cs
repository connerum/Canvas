using System;

namespace DomainModel
{
    public class Post
    {
        public int PostID { get; set; }
        public Student Name { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public void WriteReply(Post post) { /* Implementation */ }
    }
}
