using System.Collections.Generic;

namespace DomainModel
{
    public class Discussion
    {
        public int DiscussionID { get; set; }
        public string Title { get; set; }
        public List<Post> Posts { get; set; }

        public void CreatePost(Post post) { /* Implementation */ }
        public void ViewPosts() { /* Implementation */ }
    }
}
