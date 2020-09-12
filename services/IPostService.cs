using FarraBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarraBook.services
{
    public interface IPostService
    {
        List<Post> GetPosts();

        Post GetPostbyId(Guid postId);

        bool UpdatePost(Post postToUpdate);
    }
}
