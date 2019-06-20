using System.Collections.Generic;

namespace webapi.Models
{
    public class PostRepository : IPostRepository
    {
        private BloggingContext context { get; }
        
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }

        public PostRepository(BloggingContext context)
        {
            this.context = context;
        }

        public void AddPost(Post post)
        {
            if (post.BlogId != 0)
            {
                context.Posts.Add(post);
            }
        }
    }
}