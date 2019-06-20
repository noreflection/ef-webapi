using System.Collections.Generic;

namespace webapi.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; set; }     
        IEnumerable<Blog> Blogs { get; set; }
    }
}